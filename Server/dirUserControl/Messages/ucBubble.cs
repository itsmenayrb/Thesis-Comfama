using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirUserControl.Messages
{
    public partial class ucBubble : UserControl
    {
        public ucBubble()
        {
            InitializeComponent();
        }

        public ucBubble(string message, string time, messageType msgType)
        {
            InitializeComponent();
            lblMessage.Text = message;
            lblTime.Text = time;

            if (msgType.ToString() == "send")
            {
                //outgoing messages
                this.BackColor = Color.FromArgb(32, 206, 245);

            }
            else if (msgType.ToString() == "received")
            {
                //incoming messages
                this.BackColor = Color.FromArgb(245, 245, 245);
                lblMessage.ForeColor = Color.Black;
                lblTime.ForeColor = Color.Gray;
            }

            _setHeight();
        }

        void _setHeight()
        {
            Size maxSize = new Size(480, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(lblMessage.Text, lblMessage.Font, lblMessage.Width);

            lblMessage.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            lblTime.Top = lblMessage.Bottom + 5;

            this.Height = lblTime.Bottom + 10;
        }

        private void ucBubble_Resize(object sender, EventArgs e)
        {
            _setHeight();
        }
    }

    public enum messageType
    {
        send,
        received
    }
}
