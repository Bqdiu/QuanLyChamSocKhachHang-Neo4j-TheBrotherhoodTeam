using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Main : Form
    {
        Home home;
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;    
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_request_Click(object sender, EventArgs e)
        {

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(home == null)
            {
                home = new Home();
                home.FormClosed += Home_Closed;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }else
            {
                home.Activate();
            }
        }
        private void Home_Closed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }
    }
}
