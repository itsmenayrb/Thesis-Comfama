using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.RemoteManagement
{
    public partial class ViewOnly : Form
    {
        public static ViewOnly mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public string _machineName { get; set; }
        public string _inSession { get; set; }

        public ViewOnly()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ViewOnly_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btnInSession.Text = _inSession;
            timerDisplayScreenCapture.Start();
        }

        private void loadSelectedMachineScreen()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT screenImage FROM RemotePC WHERE machineName=@machineName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machineName", _machineName);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            pbScreenImage.Image = Image.FromStream(new MemoryStream((Byte[])reader["screenImage"]));
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading selected remote pc: " + ex.Message, "View Only");
            }
        }

        private void timerDisplayScreenCapture_Tick(object sender, EventArgs e)
        {
            loadSelectedMachineScreen();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Exit viewing?", "View Only", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                dirUserControl.RemoteManagement.ucRemoteManagement.mainInstance.StartServer();
                this.Close();
            }
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                Bitmap bitmap = ImageScreenshot(pbScreenImage);
                sfd.Title = "Select folder";
                sfd.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    bitmap.Save(sfd.FileName);
                }
            }
        }

        private static Bitmap ImageScreenshot(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphic = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            graphic.CopyFromScreen(rect.Location, Point.Empty, control.Size);
            return bitmap;
        }
    }
}
