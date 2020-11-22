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
            Methods methods = new Methods();
            createdDB = methods.checkFiles();
            //methods.createDB();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            btn_check.Enabled = false;
            form_parent frm = new form_parent();

            //Task.Factory.StartNew(() =>
            //{
            //    frm.pic_loading.Visible = true;
            //});
            //pic_loading.Visible = true;

            if (createdDB)
            {
                string errMsg = frm.methods_checkpass(tb_pass.Text);

                if (tb_pass.Text == "")
                    MessageBox.Show("password box can't be empty", " ERROR!!...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (errMsg == "")
                {
                    verified = true;
                    Close();
                }
                else
                    MessageBox.Show(errMsg, " ERROR!!...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tb_pass.Text == "")
                    MessageBox.Show("password box can't be empty", " ERROR!!...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    frm.methods_createDB(tb_pass.Text);
                    verified = true;
                    Close();
                }
            }
            //pic_loading.Visible = true;

            btn_check.Enabled = true;

            //if (createdDB)
            //{
            //    string errMsg = methods.checkPass(tb_pass.Text);

            //    if (tb_pass.Text == "")
            //        MessageBox.Show("password box can't be empty");

            //    else if (errMsg == "")
            //    {
            //        verified = true;
            //        Close();
            //    }
            //    else
            //        MessageBox.Show(errMsg, " ERROR!!...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    methods.createDB(tb_pass.Text);
            //    verified = true;
            //    Close();
            //}
            //btn_check.Enabled = true;

            //else
            //{
            //    verified = true;
            //    Close();
            //}
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
