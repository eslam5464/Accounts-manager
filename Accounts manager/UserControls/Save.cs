using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounts_manager.Classes;
using Accounts_manager.Classes.Models;

namespace Accounts_manager.UserControls
{
    public partial class Save : UserControl
    {
        public Save()
        {
            InitializeComponent();
        }

        private void btn_save_addData_Click(object sender, EventArgs e)
        {
            AccountModel account = new AccountModel();

            if (tb_save_siteName.Text != "")
            {
                try
                {
                    btn_save_addData.Enabled = false;
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

                    Logger.Log(new LogModel()
                    {
                        ClassName = "DataAccess",
                        LogLevel = Logger.INFO,
                        LogMessage = $"Added an account",
                        MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                    });
                    btn_save_addData.Enabled = true;
                    MessageBox.Show("Account saved", "Sucess!!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    btn_save_addData.Enabled = true;
                    Logger.Log(new LogModel()
                    {
                        ClassName = this.GetType().Name,
                        LogLevel = Logger.ERROR,
                        LogMessage = $"while saving the account & error: {ex.Message}",
                        MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                    });
                }
            }
            else
            {
                MessageBox.Show("please fill the required boxes");
            }
        }

        private void btn_save_clearTB_Click(object sender, EventArgs e)
        {
            TextBox[] AllTextBoxes ={
                tb_save_answer,
                tb_save_email,
                tb_save_otherInfo,
                tb_save_password,
                tb_save_phone,
                tb_save_question,
                tb_save_siteName,
                tb_save_username,
            };
            foreach (TextBox textBox in AllTextBoxes)
            {
                textBox.Text = "";
            }

            Logger.Log(new LogModel()
            {
                ClassName = this.GetType().Name,
                LogLevel = Logger.INFO,
                LogMessage = $"User cleared all text boxes",
                MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
            });
        }
    }
}
