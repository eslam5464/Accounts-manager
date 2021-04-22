using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounts_manager
{
    partial class form_dbPass : Form
    {
        public bool verified = false;
        private bool createdDB = false;
        public form_dbPass()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            btn_check.Enabled = false;

        }

        private void setForm(bool isCreatedDB)
        {
            if (!isCreatedDB)
            {
                Text = "Set new password for you database!!!...";
                lbl_password.Text = "Set password: ";
                lbl_password.Left += 30;
                tb_pass.PasswordChar = '\0';
                btn_check.Text = "Set";
            }
        }

        private void form_dbPass_Load(object sender, EventArgs e)
        {
            setForm(createdDB);
        }

        private void tb_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_check.PerformClick();
            }
        }
    }
}
