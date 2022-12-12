using Accounts_manager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Accounts_manager
{
    public partial class form_edit : Form
    {
        public form_edit()
        {
            InitializeComponent();
            LoadList();
        }

        private List<AccountModel> accounts, accounts_temp;
        //private Control selectedControl = null, prevSelectedControl = null;
        private bool fetchingData = false;
        private static AccountModel account;
        private int lb_selectedIndex, lb_selectedIndexPrev;

        private void LoadList()
        {
            accounts_temp = DataAccess.LoadData();
            accounts = new List<AccountModel>();
            lb_edit.DataSource = null;

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

            lb_edit.DataSource = accounts;

            lb_edit.ValueMember = "Id";
            lb_edit.DisplayMember = "SiteName";

            cb_searchBy.SelectedIndex = 0;
        }

        private void populateTBs(AccountModel account)
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

        //private void changeSelectedAcc()
        //{
        //    fetchingData = true;
        //    Thread.Sleep(2000);
        //    account = accounts.Find(x => x.Id == int.Parse(lb_edit.SelectedValue.ToString()));
        //    fetchingData = false;
        //}

        //private string selectedAccID = "-1";

        private void form_edit_Load(object sender, EventArgs e)
        {
            lbl_edit.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_edit_header.Height = Height / 15;
        }

        private void form_edit_Resize(object sender, EventArgs e)
        {
            lbl_edit.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_edit_header.Height = Height / 15;
        }

        private void cb_searchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cb_searchBy.SelectedItem.ToString();
            if (selectedItem == "Site Name")
                selectedItem = "SiteName";

            if (selectedItem == "Date created")
                selectedItem = "DateCreated";

            lb_edit.ValueMember = "Id";
            lb_edit.DisplayMember = selectedItem;
        }

        private void lb_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!fetchingData)
            //    new Thread(new ThreadStart(changeSelectedAcc)).Start();

            try
            {
                if (lb_edit.SelectedValue != null && account != null)
                {
                    var account = accounts.Find(x => x.Id == int.Parse(lb_edit.SelectedValue.ToString()));

                    Debug.WriteLine($"-> selected account with id: {account.Id}");
                    populateTBs(account);

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btn_save_changes_Click(object sender, EventArgs e)// to do
        {
            if (lb_edit.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save changes?", "Notice!.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    var account = accounts.Find(x => x.Id == int.Parse(lb_edit.SelectedValue.ToString()));

                }
            }
        }

        private void btn_deleteAcc_Click(object sender, EventArgs e)
        {
            if (lb_edit.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Alarm!.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var account = accounts.Find(x => x.Id == int.Parse(lb_edit.SelectedValue.ToString()));
                        DataAccess.DeleteAccount(account);

                        if (lb_edit.SelectedIndex > -1)
                            lb_edit.SelectedIndex--;

                        LoadList();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
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
    }
}
