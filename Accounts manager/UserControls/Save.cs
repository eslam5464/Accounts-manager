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

        private async void btn_save_addData_Click(object sender, EventArgs e)
        {
            if (tb_save_siteName.Text != "")
            {
                try
                {
                    btn_save_addData.Enabled = false;

                    AccountModel account = new AccountModel()
                    {
                        SiteName = tb_save_siteName.Text,
                        Username = tb_save_username.Text,
                        Password = tb_save_password.Text,
                        Email = tb_save_email.Text,
                        Phone = tb_save_phone.Text,
                        Question = tb_save_question.Text,
                        Answer = tb_save_answer.Text,
                        OtherInfo = tb_save_otherInfo.Text,
                        DateCreated = DateTime.Now.ToString("yyyy/M/dd hh:mm tt"),
                    };

                    account = await Security.EncryptOneAccount(account);

                    DataAccess.AddAccount(account);

                    Logger.Log(new LogModel()
                    {
                        ClassName = this.GetType().Name,
                        LogLevel = Logger.INFO,
                        LogMessage = $"Added an account",
                        MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                    });
                    btn_save_addData.Enabled = true;
                    MessageBox.Show("Account saved", "Success!!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                textBox.Text = "";

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
