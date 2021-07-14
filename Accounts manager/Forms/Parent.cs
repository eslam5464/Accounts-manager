using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Accounts_manager
{
    public partial class form_parent : Form
    {
        Button btn_selected, btn_selectedPrev = new Button();

        public form_parent()
        {
            InitializeComponent();
        }

        #region Forms methods
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
        private void RemoveActiveForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                panel_childForm.Controls.Remove(activeForm);
                panel_childForm.Tag = null;
                activeForm = null;
            }
        }

        private void CheckSelectedButton(Button SelectedButton)
        {
            if (btn_selected == null && btn_selectedPrev == null)
            {
                btn_selected = SelectedButton;
                Debug.WriteLine($"-> both null");
            }
            else
            {
                btn_selectedPrev = btn_selected;
                btn_selected = SelectedButton;

                if (btn_selectedPrev != null)
                    btn_selectedPrev.BackColor = Color.FromArgb(51, 47, 57);
                btn_selected.BackColor = Color.FromArgb(98, 42, 101);

                Debug.WriteLine($"-> btn selected: {btn_selected.BackColor}, btn prev: {btn_selected.BackColor}");
            }
            //else
            //{

            //    //btn_selectedPrev.BackColor = Color.FromArgb(51, 47, 57);
            //    //btn_selected.BackColor = Color.FromArgb(51, 47, 57);
            //    //btn_selected = btn_selectedPrev = null;
            //    //Debug.WriteLine($"else statement");
            //}
        }

        private void Form_parent_Load(object sender, EventArgs e)
        {
            //new Thread(() => methods.ConnectDB()).Start();

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

            form_dbPass frm = new form_dbPass();
            frm.ShowDialog();
        }

        #endregion

        #region Side menu buttons
        private void Btn_main_Click(object sender, EventArgs e)
        {
            openChildForm(new form_main());
            CheckSelectedButton(btn_main);

            if (btn_selected != null && btn_selectedPrev != null)
                Debug.WriteLine($"-> Selected: {btn_selected.Name}, prev: {btn_selectedPrev.Name}");
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            openChildForm(new form_save());
            CheckSelectedButton(btn_save);

            if (btn_selected != null && btn_selectedPrev != null)
                Debug.WriteLine($"-> Selected: {btn_selected.Name}, prev: {btn_selectedPrev.Name }");
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            openChildForm(new form_edit());
            CheckSelectedButton(btn_edit);

            if (btn_selected != null && btn_selectedPrev != null)
                Debug.WriteLine($"-> Selected: {btn_selected.Name}, prev: {btn_selectedPrev.Name}");
        }

        private void Btn_about_Click(object sender, EventArgs e)
        {
            openChildForm(new form_about());
            CheckSelectedButton(btn_about);

            if (btn_selected != null && btn_selectedPrev != null)
                Debug.WriteLine($"-> Selected: {btn_selected.Name}, prev: {btn_selectedPrev.Name}");
        }

        #endregion


        #region Logo

        private void Pic_logo_Click(object sender, EventArgs e)
        {
            RemoveActiveForm();
        }

        private void Pic_logo_MouseEnter(object sender, EventArgs e)
        {
            pic_logo.BackColor = Color.FromArgb(148, 63, 152);
        }

        private void Pic_logo_MouseLeave(object sender, EventArgs e)
        {
            pic_logo.BackColor = Color.Silver;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void Form_parent_FormClosing(object sender, FormClosingEventArgs e)
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
