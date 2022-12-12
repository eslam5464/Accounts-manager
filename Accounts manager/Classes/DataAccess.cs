using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using System.Diagnostics;

namespace Accounts_manager.Classes
{
    class DataAccess
    {
        public static List<AccountModel> LoadData()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AccountModel>("select * from Accounts", new DynamicParameters());

                Debug.WriteLine($"-> Loaded all data from Accounts");
                return output.ToList();
            }
        }

        public static void AddAccount(AccountModel account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Accounts ('SiteName', 'Username', 'Password', 'Email', 'Phone', 'Question', 'Answer', 'OtherInfo', 'DateCreated') " +
                    "values (@SiteName, @Username, @Password, @Email, @Phone, @Question, @Answer, @OtherInfo, @DateCreated)", account);

                Debug.WriteLine($"-> Added {account.SiteName} at {account.DateCreated}");
            }
        }

        public static void EditAccount(AccountModel account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Accounts set 'SiteName' = @SiteName, 'Username'= @Username, 'Password'= @Password," +
                    " 'Email'= @Email, 'Phone'= @Phone, 'Question'= @Question, 'Answer'= @Answer, 'OtherInfo'= @OtherInfo" +
                    "where Id = @Id ", account);

                string DateNow= DateTime.Now.ToString("yyyy/M/dd hh:mm tt");

                Debug.WriteLine($"-> At: {DateNow} - Updated account Id= {account.Id}, created in: {account.DateCreated}");
            }
        }

        public static void DeleteAccount(AccountModel account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Accounts where Id = @Id ", account);

                string DateNow = DateTime.Now.ToString("yyyy/M/dd hh:mm tt");

                Debug.WriteLine($"-> At: {DateNow} - Deleted account Id= {account.Id}, created in: {account.DateCreated}");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
