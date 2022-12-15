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
    public partial class Edit : UserControl
    {
        private List<AccountModel> accounts = new List<AccountModel>();

        public Edit()
        {
            InitializeComponent();
        }

        private async void btn_save_changes_Click(object sender, EventArgs e)
        {
            if (lb_edit.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save changes?", "Notice!.", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int AccountId = int.Parse(lb_edit.SelectedValue.ToString());
                        var account = accounts.Find(x => x.Id == AccountId);
                        string AccountSiteName = tb_siteName.Text;

                        account.Answer = tb_answer.Text;
                        account.Email = tb_email.Text;
                        account.OtherInfo = tb_otherInfo.Text;
                        account.Password = tb_password.Text;
                        account.Phone = tb_phone.Text;
                        account.Question = tb_question.Text;
                        account.SiteName = tb_siteName.Text;
                        account.Username = tb_username.Text;

                        account = await Security.EncryptOneAccount(account);

                        DataAccess.EditAccount(account);

                        await LoadAccounts();

                        int EditedAccountIndex = lb_edit.FindStringExact(AccountSiteName);

                        if (EditedAccountIndex > 0)
                            lb_edit.SelectedIndex = EditedAccountIndex;
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(new LogModel()
                        {
                            ClassName = this.GetType().Name,
                            LogLevel = Logger.ERROR,
                            LogMessage = $"While saving changes for account with id: {lb_edit.SelectedValue} & error: {ex.Message}",
                            MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                        });
                    }

                }
            }
        }

        private async void btn_deleteAcc_Click(object sender, EventArgs e)
        {
            if (lb_edit.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this account?",
                    "Alarm!.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var account = accounts.Find(x => x.Id == int.Parse(lb_edit.SelectedValue.ToString()));
                        DataAccess.DeleteAccount(account);

                        if (lb_edit.SelectedIndex > -1)
                            lb_edit.SelectedIndex--;

                        await LoadAccounts();
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(new LogModel()
                        {
                            ClassName = this.GetType().Name,
                            LogLevel = Logger.INFO,
                            LogMessage = $"While deleting account with id: {lb_edit.SelectedValue} & error: {ex.Message}",
                            MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                        });
                    }
                }

                if (lb_edit.Items.Count == 0)
                {
                    tb_siteName.Text = ""; tb_username.Text = "";
                    tb_password.Text = ""; tb_email.Text = ""; tb_phone.Text = "";
                    tb_question.Text = ""; tb_answer.Text = ""; tb_otherInfo.Text = "";
                    tb_dateCreated.Text = "";
                }
            }
        }

        internal async Task LoadAccounts()
        {

            btn_refresh.Enabled = false;
            try
            {
                lb_edit.DataSource = null;
                lb_edit.Items.Add("Please wait for the list to load...");

                accounts = await Security.DecryptAccounts(DataAccess.GetAllAccounts());
                accounts = accounts.OrderBy(o => o.SiteName).ToList();

                lb_edit.DataSource = accounts;
                lb_edit.ValueMember = "Id";
                lb_edit.DisplayMember = "SiteName";

                cb_searchBy.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Logger.Log(new LogModel()
                {
                    ClassName = this.GetType().Name,
                    LogLevel = Logger.INFO,
                    LogMessage = $"While loading accounts in edit & error: {ex.Message}",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
            }
            finally
            {
                btn_refresh.Enabled = true;
            }
        }

        private void PopulateTBs(AccountModel account)
        {
            tb_answer.Text = account.Answer;
            tb_email.Text = account.Email;
            tb_otherInfo.Text = account.OtherInfo;
            tb_password.Text = account.Password;
            tb_phone.Text = account.Phone;
            tb_question.Text = account.Question;
            tb_siteName.Text = account.SiteName;
            tb_username.Text = account.Username;
            tb_dateCreated.Text = account.DateCreated;
        }

        private void lb_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_edit.SelectedValue != null && lb_edit.SelectedValue.GetType() == typeof(int))
                try
                {
                    var account = accounts.Find(x => x.Id == int.Parse(lb_edit.SelectedValue.ToString()));
                    if (account != null)
                        Logger.Log(new LogModel()
                        {
                            ClassName = this.GetType().Name,
                            LogLevel = Logger.INFO,
                            LogMessage = $"Selected account with id: {account.Id}",
                            MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                        });

                    PopulateTBs(account);
                }
                catch (Exception ex)
                {
                    Logger.Log(new LogModel()
                    {
                        ClassName = this.GetType().Name,
                        LogLevel = Logger.ERROR,
                        LogMessage = $"While selecting index '{lb_edit.SelectedValue}' '{lb_edit.SelectedItem}' " +
                            $"in listbox main & error: {ex.Message}",
                        MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                    });
                }

        }

        private async void Edit_Load(object sender, EventArgs e)
        {
            await LoadAccounts();
        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {
            await LoadAccounts();
        }
    }
}
