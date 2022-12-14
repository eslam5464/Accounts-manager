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
using Accounts_manager.Classes;
using Accounts_manager.Classes.Models;

namespace Accounts_manager
{
    public partial class form_parent : Form
    {
        Button btn_selected, btn_selectedPrev = new Button();
        private readonly UserControls.Main uc_main = new UserControls.Main();
        private readonly UserControls.Blank uc_blank = new UserControls.Blank();
        private readonly UserControls.Save uc_save = new UserControls.Save();
        private readonly UserControls.Edit uc_edit = new UserControls.Edit();
        private readonly UserControls.Settings uc_settings = new UserControls.Settings();

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

        //private void SelectButton(Button SelectedButton, bool HideAllSubMenus)
        //{
        //    LogModel log = new LogModel
        //    {
        //        ClassName = this.Name,
        //        LogLevel = Logger.INFO,
        //        LogMessage = $"User clicked on <{SelectedButton.Name}> button",
        //        MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
        //    };
        //    Logger.Log(log);

        //    if (!pan_left_btn_click.Visible)
        //        pan_left_btn_click.Visible = true;

        //    if (HideAllSubMenus)
        //        HideSubMenu();

        //    pan_left_btn_click.Height = SelectedButton.Height;
        //    pan_left_btn_click.Top = SelectedButton.Top;
        //}


        private void ShowControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        private void SetSelectedButton(Button SelectedButton)
        {
            if (btn_selected == null && btn_selectedPrev == null)
            {
                btn_selected = SelectedButton;

                Logger.Log(new LogModel()
                {
                    ClassName = this.GetType().Name,
                    LogLevel = Logger.INFO,
                    LogMessage = $"<{btn_selected.Name}> and <{btn_selectedPrev.Name}> are null",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
            }
            else
            {
                btn_selectedPrev = btn_selected;
                btn_selected = SelectedButton;

                if (btn_selectedPrev != null)
                    btn_selectedPrev.BackColor = Color.FromArgb(51, 47, 57);
                btn_selected.BackColor = Color.FromArgb(98, 42, 101);

                Logger.Log(new LogModel()
                {
                    ClassName = this.GetType().Name,
                    LogLevel = Logger.INFO,
                    LogMessage = $"Button selected: <{btn_selected.Name}>, button previous: <{btn_selected.Name}>",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
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

            UserControl[] AllUserControls = {
                uc_main,
                uc_blank,
                uc_save,
                uc_edit,
                uc_settings,
            };

            foreach (UserControl userControl in AllUserControls)
                panel_childForm.Controls.Add(userControl);

            uc_blank.BringToFront();

            form_dbPass frm = new form_dbPass();
            frm.ShowDialog();
        }

        #endregion

        #region Side menu buttons
        private void Btn_main_Click(object sender, EventArgs e)
        {
            ShowControl(uc_main);
            SetSelectedButton(btn_main);

            uc_main.LoadAccounts();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            ShowControl(uc_save);
            SetSelectedButton(btn_save);
        }

        private async void Btn_edit_Click(object sender, EventArgs e)
        {
            ShowControl(uc_edit);
            SetSelectedButton(btn_edit);
            await uc_edit.LoadAccounts();

            //if (btn_selected != null && btn_selectedPrev != null)
            //    Debug.WriteLine($"-> Selected: {btn_selected.Name}, prev: {btn_selectedPrev.Name}");
        }

        private void Btn_about_Click(object sender, EventArgs e)
        {
            ShowControl(uc_settings);
            SetSelectedButton(btn_about);
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
