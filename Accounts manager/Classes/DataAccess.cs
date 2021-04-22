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
        public static List<AccountDetails> LoadData()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AccountDetails>("select * from Accounts", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void AddAccount(AccountDetails account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Accounts ('Site name', 'Username', 'Password', 'Email', 'Phone', 'Question', 'Answer', 'Other information', 'Date created') " +
                    "values (@SiteName, @Username, @Password, @Email, @Phone, @Question, @Answer, @OtherInfo, @DateCreated)", account);
            }
            Debug.WriteLine($"Added {account.SiteName} at {account.DateCreated}");
        }

        public static void EditAccount(AccountDetails account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Accounts set 'Site name' = @SiteName, 'Username'= @Username, 'Password'= @Password," +
                    " 'Email'= @Email, 'Phone'= @Phone, 'Question'= @Question, 'Answer'= @Answer, 'Other information'= @OtherInfo" +
                    "where Id = @Id ", account);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
