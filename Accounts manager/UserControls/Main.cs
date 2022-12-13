using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounts_manager.Classes.Models;
using Accounts_manager.Classes;

namespace Accounts_manager.UserControls
{
    public partial class Main : UserControl
    {

        private List<AccountModel> accounts, accounts_temp;
        private Control selectedControl = null, prevSelectedControl = null;

        public Main()
        {
            InitializeComponent();
        }

        private void cb_searchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cb_searchBy.SelectedItem.ToString();

            if (selectedItem == "Site Name")
                selectedItem = "SiteName";

            if (selectedItem == "Date created")
                selectedItem = "DateCreated";

            lb_main.ValueMember = "Id";
            lb_main.DisplayMember = selectedItem;

            Logger.Log(new LogModel()
            {
                ClassName = this.GetType().Name,
                LogLevel = Logger.INFO,
                LogMessage = $"<{((ComboBox)sender).Name}> index changed to '{cb_searchBy.Text}'",
                MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
            });
        }

        public async void LoadAccounts()
        {
            accounts_temp = DataAccess.LoadData();
            accounts = new List<AccountModel>();
            lb_main.DataSource = null;
            lb_main.Items.Add("Please wait for the list to load...");

            foreach (AccountModel account in accounts_temp)
            {
                account.Answer = await Task.Run(() => Methods.Decrypt(account.Answer));
                account.DateCreated = await Task.Run(() => Methods.Decrypt(account.DateCreated));
                account.Email = await Task.Run(() => Methods.Decrypt(account.Email));
                account.OtherInfo = await Task.Run(() => Methods.Decrypt(account.OtherInfo));
                account.Password = await Task.Run(() => Methods.Decrypt(account.Password));
                account.Phone = await Task.Run(() => Methods.Decrypt(account.Phone));
                account.Question = await Task.Run(() => Methods.Decrypt(account.Question));
                account.SiteName = await Task.Run(() => Methods.Decrypt(account.SiteName));
                account.Username = await Task.Run(() => Methods.Decrypt(account.Username));

                await Task.Run(() => accounts.Add(account));
            }

            lb_main.DataSource = accounts;
            lb_main.ValueMember = "Id";
            lb_main.DisplayMember = "SiteName";

            cb_searchBy.SelectedIndex = 0;
        }

        private void lb_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var account = accounts.Find(x => x.Id == int.Parse(lb_main.SelectedValue.ToString()));
                if (account != null)
                    Logger.Log(new LogModel()
                    {
                        ClassName = this.GetType().Name,
                        LogLevel = Logger.INFO,
                        LogMessage = $"selected account with id: {account.Id}",
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
                    LogMessage = $"while selecting index in listbox main & error: {ex.Message}",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
            }
        }

        private void tbs_main(object sender, EventArgs e)
        {
            prevSelectedControl = selectedControl;
            selectedControl = (Control)sender;

            if (prevSelectedControl != null)
                prevSelectedControl.BackColor = Color.Empty;

            if (selectedControl != null)
                selectedControl.BackColor = Color.SkyBlue;
        }

        private void PopulateTBs(AccountModel account)
        {
            if (account != null)
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
        }

        private void btn_copy_control_txt_Click(object sender, EventArgs e)
        {
            if (selectedControl != null && selectedControl.Text != null & selectedControl.Text.Trim() != "")
            {
                Clipboard.SetText(selectedControl.Text);
                Logger.Log(new LogModel()
                {
                    ClassName = this.GetType().Name,
                    LogLevel = Logger.INFO,
                    LogMessage = $"Copied text from <{selectedControl.Name}> to clipboard",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
            }
        }
    }
}
