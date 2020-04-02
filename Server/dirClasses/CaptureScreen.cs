using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Server.dirClasses
{
    class CaptureScreen
    {
        public struct SIZE
        {
            public int cx;
            public int cy;
        }

        static Bitmap CaptureDesktop()
        {
            SIZE size;
            IntPtr hBitmap;
            IntPtr hDC = Win32.GetDC(Win32.GetDesktopWindow());
            IntPtr hMemDC = GDI.CreateCompatibleDC(hDC);

            size.cx = Win32.GetSystemMetrics
                      (Win32.SM_CXSCREEN);

            size.cy = Win32.GetSystemMetrics
                      (Win32.SM_CYSCREEN);

            hBitmap = GDI.CreateCompatibleBitmap(hDC, size.cx, size.cy);

            if (hBitmap != IntPtr.Zero)
            {
                IntPtr hOld = (IntPtr)GDI.SelectObject
                                       (hMemDC, hBitmap);

                GDI.BitBlt(hMemDC, 0, 0, size.cx, size.cy, hDC,
                                               0, 0, GDI.SRCCOPY);

                GDI.SelectObject(hMemDC, hOld);
                GDI.DeleteDC(hMemDC);
                Win32.ReleaseDC(Win32.GetDesktopWindow(), hDC);
                Bitmap bmp = System.Drawing.Image.FromHbitmap(hBitmap);
                GDI.DeleteObject(hBitmap);
                GC.Collect();
                return bmp;
            }
            return null;

        }

        static Bitmap CaptureCursor(ref int x, ref int y)
        {
            Bitmap bmp;
            IntPtr hicon;
            Win32.CURSORINFO ci = new Win32.CURSORINFO();
            Win32.ICONINFO icInfo;
            ci.cbSize = Marshal.SizeOf(ci);
            if (Win32.GetCursorInfo(out ci))
            {
                if (ci.flags == Win32.CURSOR_SHOWING)
                {
                    hicon = Win32.CopyIcon(ci.hCursor);
                    if (Win32.GetIconInfo(hicon, out icInfo))
                    {
                        x = ci.ptScreenPos.x - ((int)icInfo.xHotspot);
                        y = ci.ptScreenPos.y - ((int)icInfo.yHotspot);

                        Icon ic = Icon.FromHandle(hicon);
                        bmp = ic.ToBitmap();
                        return bmp;
                    }
                }
            }

            return null;
        }

        public static Bitmap CaptureDesktopWithCursor()
        {
            int cursorX = 0;
            int cursorY = 0;
            Bitmap desktopBMP;
            Bitmap cursorBMP;
            Bitmap finalBMP;
            Graphics g;
            Rectangle r;

            desktopBMP = CaptureDesktop();
            cursorBMP = CaptureCursor(ref cursorX, ref cursorY);
            if (desktopBMP != null)
            {
                if (cursorBMP != null)
                {
                    r = new Rectangle(cursorX, cursorY, cursorBMP.Width, cursorBMP.Height);
                    g = Graphics.FromImage(desktopBMP);
                    g.DrawImage(cursorBMP, r);
                    g.Flush();

                    return desktopBMP;
                }
                else
                    return desktopBMP;
            }

            return null;

        }
    }
}
