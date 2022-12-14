using Dapper;
using Accounts_manager.Classes.Models;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;

namespace Accounts_manager.Classes
{
    class Logger
    {
        private static readonly string AppLogFileFolder = "Data",
            AppLogFileName = "app",
            AppLogFileExtention = ".log",
            AppLogFile = $@"{AppLogFileFolder}\{AppLogFileName}{AppLogFileExtention}";

        public static string INFO = "INFO", DEBUG = "DEBUG", ERROR = "ERROR",
            WARNING = "WARNING", CRITICAL = "CRITICAL";

        //public async static Task CreateLogDB()
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(GlobalVars.LoadConnectionString()))
        //    {
        //        await Task.Run(() => cnn.Execute(@"CREATE TABLE IF NOT EXISTS 'Log' (
        //                        'Id'    INTEGER NOT NULL,
        //                        'Date'  TEXT NOT NULL,
        //                        'MethodName'    TEXT NOT NULL,
        //                        'ClassName' TEXT NOT NULL,
        //                        'LoggedUserId'  INTEGER NOT NULL,
        //                        'LoggedUserName'    TEXT NOT NULL,
        //                        'LogLevel'  TEXT NOT NULL,
        //                        'LogMessage'    TEXT NOT NULL,
        //                        PRIMARY KEY('Id' AUTOINCREMENT)); "));
        //    }

        //}

        //public static void Log(string Message, string MethodName, string MethodClass, string LogLevel)
        public static void Log(LogModel logModel)
        {
            using (StreamWriter w = File.AppendText(AppLogFile))
            {
                LogString(logModel, w);
            }

            //using (IDbConnection cnn = new SQLiteConnection(GlobalVars.LoadConnectionString()))
            //{
            //    //var output = cnn.Query<LogModel>("INSERT");
            //    cnn.Execute($"INSERT INTO 'main'.'Log' ('Date', 'MethodName', 'ClassName', 'LogLevel', 'LogMessage') VALUES " +
            //        $"(@Date, @MethodName, @ClassName, @LogLevel, @LogMessage)", logModel);
            //}
        }

        private static void LogString(LogModel logModel, TextWriter Writer)
        {

            string DateTimeNow = DateTime.Now.ToString("yyyy/M/dd hh:mm:ss tt");
            logModel.Date = DateTimeNow;

            try
            {
                logModel.LogMessage = logModel.LogMessage.Replace("'", "*");
                using (IDbConnection cnn = new SQLiteConnection(GlobalVars.LoadConnectionString()))
                {
                    string query = $"INSERT INTO 'main'.'Log' ('Date', 'MethodName', 'ClassName', 'LogLevel', 'LogMessage') VALUES " +
                            $"(@Date, @MethodName, @ClassName, @LogLevel, @LogMessage)";

                    cnn.Query<LogModel>(query, logModel);
                }
            }
            catch (Exception ex)
            {
                Writer.Write("Log Entry : ");
                Writer.WriteLine($"Cannot log into database & error: {ex.Message}");
                Writer.WriteLine($"{DateTimeNow} - Method: {logModel.MethodName} - ClassName: {logModel.ClassName} - Log level: {logModel.LogLevel}");
                Writer.WriteLine($"  #{logModel.LogMessage}");
                Writer.WriteLine("--------------------------------------------------------------");
            }
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
