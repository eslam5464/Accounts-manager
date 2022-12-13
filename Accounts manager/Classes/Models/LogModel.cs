using System;

namespace Accounts_manager.Classes.Models
{
    class LogModel
    {
        public long Id { get; set; }
        public string Date { get; set; }
        public string MethodName { get; set; }
        public string ClassName { get; set; }
        public string LogLevel { get; set; }
        public string LogMessage { get; set; }
    }
}
