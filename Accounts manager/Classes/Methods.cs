using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using Accounts_manager.Classes;
using Accounts_manager.Classes.Models;
using System.Windows.Forms;

namespace Accounts_manager
{
    public class Methods
    {
        //public string DBpassword = "";

        internal static bool checkDataFileExists()
        {
            if (!File.Exists("/AccountsData.db"))
                return true;

            return false;
        }

        internal string CheckPass(string pass)
        {

            return "";
        }

        public void ConnectDB()
        {

        }

        internal async Task ExportToCSV(List<AccountModel> accounts)
        {
            DataTable accountsTable = await ListToDataTable(accounts);

            string fileLocation = await PromptSaveFileDialog("Accounts.csv");

            await DataTableToCSV(accountsTable, fileLocation);
        }

        internal async virtual Task<DataTable> ListToDataTable<T>(List<T> items)
        {
            try
            {
                DataTable dataTable = new DataTable(typeof(T).Name);

                System.Reflection.PropertyInfo[] Props =
                    await Task.Run(() => typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance));

                foreach (System.Reflection.PropertyInfo prop in Props)
                {
                    await Task.Run(() => dataTable.Columns.Add(prop.Name, prop.PropertyType));
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        values[i] = await Task.Run(() => Props[i].GetValue(item, null));
                    }
                    await Task.Run(() => dataTable.Rows.Add(values));
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                Logger.Log(new LogModel()
                {
                    ClassName = this.GetType().Name,
                    LogLevel = Logger.INFO,
                    LogMessage = $"While converting list to datatable & error: {ex.Message}",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
                return null;
            }
        }

        internal async Task DataTableToCSV(DataTable dataTable, string fileName)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                IEnumerable<string> columnNames = await Task.Run(() => dataTable.Columns.Cast<DataColumn>().
                                                  Select(column => column.ColumnName));
                sb.AppendLine(string.Join(",", columnNames));

                foreach (DataRow row in dataTable.Rows)
                {
                    IEnumerable<string> fields = row.ItemArray.Select(field => string.Concat("\"",
                        field.ToString().Replace("\"", "\"\""), "\""));
                    sb.AppendLine(string.Join(",", fields));
                }

                File.WriteAllText(fileName, sb.ToString());
            }
            catch (Exception ex)
            {
                Logger.Log(new LogModel()
                {
                    ClassName = this.GetType().Name,
                    LogLevel = Logger.INFO,
                    LogMessage = $"While exporting datatable to CSV & error: {ex.Message}",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
            }
        }

        internal async static Task<string> PromptSaveFileDialog(string FileName)
        {
            string RootDriveLetter = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));

            SaveFileDialog saveFileDialog = await Task.Run(() => new SaveFileDialog
            {
                InitialDirectory = $@"{RootDriveLetter}Users\{Environment.UserName}\Desktop\",
                Title = $"Save {FileName.Split('.')[0]} Files",
                CheckPathExists = true,
                DefaultExt = $"{FileName.Split('.')[FileName.Split('.').Length - 1]}",
                Filter = $"{FileName.Split('.')[FileName.Split('.').Length - 1]} " +
                $"files (*.{FileName.Split('.')[FileName.Split('.').Length - 1]})|" +
                $"*.{FileName.Split('.')[FileName.Split('.').Length - 1]}",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = FileName,
            });

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return "";
        }

        #region security methods

        

        #endregion


    }
}
