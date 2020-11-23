﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Accounts_manager
{
    public partial class form_parent : Form
    {
        private Methods methods = new Methods();// db pass problem

        public form_parent()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm == null)
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel_childForm.Controls.Add(childForm);
                panel_childForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else if (activeForm.Name != childForm.Name)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel_childForm.Controls.Add(childForm);
                panel_childForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        private void removeActiveForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                panel_childForm.Controls.Remove(activeForm);
                panel_childForm.Tag = null;
                activeForm = null;
            }
        }

        private void form_parent_Load(object sender, EventArgs e)
        {
            new Thread(() => methods.connectDB()).Start();

            this.WindowState = Properties.Settings.Default.WindowState;

            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            this.Size = Properties.Settings.Default.WindowSize;

            if ((Location.X < Screen.PrimaryScreen.Bounds.Width - 50 && Location.X > 0) ||
                (Location.Y < Screen.PrimaryScreen.Bounds.Height - 50 && Location.Y > 0))
            {
                this.Location = Properties.Settings.Default.WindowLocation;
            }
            else
            {
                this.Location = new Point(10, 10);
            }
        }

        public string methods_checkpass(string Password)
        {
            return methods.checkPass(Password);
        }

        public void methods_createDB(string Password)
        {
            methods.createDB(Password);
        }

        //-----------------------------------------------------------------
        #region side menu buttons
        private void btn_main_Click(object sender, EventArgs e)
        {
            openChildForm(new form_main());
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            openChildForm(new form_save());
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            openChildForm(new form_edit());
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            openChildForm(new form_about());
        }

        #endregion 

        private void pic_logo_Click(object sender, EventArgs e)
        {
            removeActiveForm();
        }

        private void pic_logo_MouseEnter(object sender, EventArgs e)
        {
            pic_logo.BackColor = Color.FromArgb(148, 63, 152);
        }

        private void pic_logo_MouseLeave(object sender, EventArgs e)
        {
            pic_logo.BackColor = Color.Silver;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void form_parent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.WindowSize = this.Size;
                Properties.Settings.Default.WindowLocation = this.Location;
            }
            else
            {
                Properties.Settings.Default.WindowLocation = this.RestoreBounds.Location;
            }
            Properties.Settings.Default.WindowSize = this.Size;
            Properties.Settings.Default.WindowLocation = this.Location;
            Properties.Settings.Default.WindowState = this.WindowState;
            Properties.Settings.Default.Save();
        }

    }
}
