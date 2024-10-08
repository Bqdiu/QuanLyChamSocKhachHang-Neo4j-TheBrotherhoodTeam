﻿using App.Models;
using App.Neo4JConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Main : Form
    {

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

            OpenChildForm(new ServiceFrame());
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
            OpenChildForm(new HomeFrame());
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            currentFormChild.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }


        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeFrame());
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ServiceFrame());
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RequestFrame());
        }

    }
}
