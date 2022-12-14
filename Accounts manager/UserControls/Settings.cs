using Accounts_manager.Classes.Models;
using Accounts_manager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounts_manager.UserControls
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private async void btn_export_csv_Click(object sender, EventArgs e)
        {
            btn_export_csv.Enabled = false;
            List<AccountModel> accounts = await Security.DecryptAccounts(await Task.Run(() => DataAccess.GetAllAccounts()));
            await new Methods().ExportToCSV(accounts);
            btn_export_csv.Enabled = true;
        }
    }
}
