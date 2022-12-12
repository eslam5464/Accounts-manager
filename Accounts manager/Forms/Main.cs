using Accounts_manager.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Accounts_manager
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private List<AccountModel> accounts, accounts_temp;
        private Control selectedControl = null, prevSelectedControl = null;

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

        private void form_main_Load(object sender, EventArgs e)
        {
            //lbl_main.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            //panel_main_header.Height = Height / 15;
            LoadList();
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

            Debug.WriteLine($"-> cb_searchBy index changed to {cb_searchBy.SelectedIndex}");
        }

        private void populateTBs(AccountModel account)
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

        private void lb_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var account = accounts.Find(x => x.Id == int.Parse(lb_main.SelectedValue.ToString()));
                if (account != null)
                    Debug.WriteLine($"-> selected account with id: {account.Id}");
                populateTBs(account);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btn_copy_control_txt_Click(object sender, EventArgs e)
        {
            if (selectedControl != null)
                Clipboard.SetText(selectedControl.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoadList();
        }

        private void form_main_Resize(object sender, EventArgs e)
        {
            lbl_main.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_main_header.Height = Height / 15;
        }

        private void tb_selected_controls_Click(object sender, EventArgs e)
        {
            prevSelectedControl = selectedControl;
            selectedControl = (Control)sender;

            if (prevSelectedControl != null)
                prevSelectedControl.BackColor = Color.Empty;

            if (selectedControl != null)
                selectedControl.BackColor = Color.SkyBlue;
        }
    }
}
