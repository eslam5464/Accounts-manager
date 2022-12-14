using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using System.Diagnostics;
using Accounts_manager.Classes.Models;
using System.Configuration;

namespace Accounts_manager.Classes
{
    class DataAccess
    {
        public static List<AccountModel> GetAllAccounts()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {

                    var output = cnn.Query<AccountModel>("select * from Accounts", new DynamicParameters());

                    Logger.Log(new LogModel()
                    {
                        ClassName = "DataAccess",
                        LogLevel = Logger.INFO,
                        LogMessage = $"Loaded all Accounts",
                        MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                    });

                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(new LogModel()
                {
                    ClassName = "DataAccess",
                    LogLevel = Logger.ERROR,
                    LogMessage = $"While getting all accounts & error: {ex.Message}",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
                return null;
            }

        }

        public static void AddAccount(AccountModel account)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("insert into Accounts ('SiteName', 'Username', 'Password', 'Email', 'Phone', " +
                        "'Question', 'Answer', 'OtherInfo', 'DateCreated') values (@SiteName, @Username, @Password, " +
                        "@Email, @Phone, @Question, @Answer, @OtherInfo, @DateCreated)", account);

                    Logger.Log(new LogModel()
                    {
                        ClassName = "DataAccess",
                        LogLevel = Logger.INFO,
                        LogMessage = $"Added new account",
                        MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                    });
                }
            }
            catch (Exception ex)
            {
                Logger.Log(new LogModel()
                {
                    ClassName = "DataAccess",
                    LogLevel = Logger.ERROR,
                    LogMessage = $"While adding and account & error: {ex.Message}",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
            }
        }

        public static void EditAccount(AccountModel account)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("update Accounts set 'SiteName' = @SiteName, 'Username'= @Username, 'Password'= @Password," +
                        " 'Email'= @Email, 'Phone'= @Phone, 'Question'= @Question, 'Answer'= @Answer, 'OtherInfo'= @OtherInfo " +
                        "where Id = @Id", account);

                    Logger.Log(new LogModel()
                    {
                        ClassName = "DataAccess",
                        LogLevel = Logger.INFO,
                        LogMessage = $"Edited account with id = {account.Id}",
                        MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                    });
                }
            }
            catch (Exception)
            {
                Logger.Log(new LogModel()
                {
                    ClassName = "DataAccess",
                    LogLevel = Logger.INFO,
                    LogMessage = $"While deleting account with id = {account.Id}",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
            }
        }

        public static void DeleteAccount(AccountModel account)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("delete from Accounts where Id = @Id", account);

                    Logger.Log(new LogModel()
                    {
                        ClassName = "DataAccess",
                        LogLevel = Logger.INFO,
                        LogMessage = $"Deleted account with id = {account.Id}",
                        MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                    });
                }
            }
            catch (Exception ex)
            {
                Logger.Log(new LogModel()
                {
                    ClassName = "DataAccess",
                    LogLevel = Logger.ERROR,
                    LogMessage = $"While deleting account & error: {ex.Message}",
                    MethodName = System.Reflection.MethodInfo.GetCurrentMethod().Name,
                });
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
