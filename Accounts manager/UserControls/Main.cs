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

        private void LoadList()
        {
            accounts_temp = DataAccess.LoadData();
            accounts = new List<AccountModel>();
            lb_main.DataSource = null;

            foreach (AccountModel account in accounts_temp)
            {
                account.Answer = Methods.Decrypt(account.Answer);
                account.DateCreated = Methods.Decrypt(account.DateCreated);
                account.Email = Methods.Decrypt(account.Email);
                account.OtherInfo = Methods.Decrypt(account.OtherInfo);
                account.Password = Methods.Decrypt(account.Password);
                account.Phone = Methods.Decrypt(account.Phone);
                account.Question = Methods.Decrypt(account.Question);
                account.SiteName = Methods.Decrypt(account.SiteName);
                account.Username = Methods.Decrypt(account.Username);

                accounts.Add(account);
            }

            lb_main.DataSource = accounts;

            lb_main.ValueMember = "Id";
            lb_main.DisplayMember = "SiteName";

            cb_searchBy.SelectedIndex = 0;
        }

        private void btn_copy_control_txt_Click(object sender, EventArgs e)
        {
            if (selectedControl != null)
                Clipboard.SetText(selectedControl.Text);
        }
    }
}
