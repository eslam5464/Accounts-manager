using Accounts_manager.Classes;
using Accounts_manager.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounts_manager
{
    public partial class form_save : Form
    {
        public form_save()
        {
            InitializeComponent();
            lbl_save.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_save_header.Height = Height / 15;
        }

        private void form_save_Resize(object sender, EventArgs e)
        {
            lbl_save.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_save_header.Height = Height / 15;
        }

        private void form_save_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_addData_Click(object sender, EventArgs e)
        {
            AccountModel account = new AccountModel();

            if (tb_save_siteName.Text != "")
            {
                account.SiteName = Methods.Encrypt(tb_save_siteName.Text);
                account.Username = Methods.Encrypt(tb_save_username.Text);
                account.Password = Methods.Encrypt(tb_save_password.Text);
                account.Email = Methods.Encrypt(tb_save_email.Text);
                account.Phone = Methods.Encrypt(tb_save_phone.Text);
                account.Question = Methods.Encrypt(tb_save_question.Text);
                account.Answer = Methods.Encrypt(tb_save_answer.Text);
                account.OtherInfo = Methods.Encrypt(tb_save_otherInfo.Text);
                account.DateCreated = Methods.Encrypt(DateTime.Now.ToString("yyyy/M/dd hh:mm tt"));

                DataAccess.AddAccount(account);
                MessageBox.Show("Account saved");
            }
            else
            {
                MessageBox.Show("please fill the required boxes");
            }
        }

        private void btn_save_clearTB_Click(object sender, EventArgs e)
        {
            tb_save_answer.Text = "";
            tb_save_email.Text = "";
            tb_save_otherInfo.Text = "";
            tb_save_password.Text = "";
            tb_save_phone.Text = "";
            tb_save_question.Text = "";
            tb_save_siteName.Text = "";
            tb_save_username.Text = "";
        }

        private void tb_save_siteName_Enter(object sender, EventArgs e)
        {
            tb_save_siteName.BackColor = DefaultBackColor;
        }

        private void tb_save_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
