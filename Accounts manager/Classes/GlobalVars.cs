using System;
using System.Configuration;

namespace Accounts_manager.Classes
{
    class GlobalVars
    {
        internal static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
