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
            try
            {
                List<AccountModel> accounts = await Security.DecryptAccounts(await Task.Run(() => DataAccess.GetAllAccounts()));
                await new Methods().ExportToCSV(accounts);
            }
            catch (Exception ex)
            {
                Logger.Log(new LogModel()
                {
                    ClassName = this.GetType().Name,
                    LogLevel = Logger.ERROR,
                    LogMessage = $"While exporting csv & error: {ex.Message}",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
            }
            btn_export_csv.Enabled = true;
        }

        private async void btn_import_csv_Click(object sender, EventArgs e)
        {
            btn_import_csv.Enabled = false;
            try
            {
                //DataTable NewAccounts = new Methods().ImportFromXLSX();
                //List<DataRow> list = NewAccounts.AsEnumerable().ToList();
                //List<AccountModel> ListAccounts = await new Methods().DataTableToList<AccountModel>(NewAccounts);
                List<AccountModel> ListAccounts = new Methods().ImportFromXLSX();

                DataAccess.DeleteAllAccounts();
                foreach (AccountModel account in ListAccounts)
                    DataAccess.AddAccount(await Security.EncryptOneAccount(account));

                MessageBox.Show("File imported", "Success!.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.Log(new LogModel()
                {
                    ClassName = this.GetType().Name,
                    LogLevel = Logger.ERROR,
                    LogMessage = $"While importing csv & error: {ex.Message}",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
                MessageBox.Show("Error While importing the file", "Error!.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btn_import_csv.Enabled = true;
        }
    }
}
