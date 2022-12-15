using System;

namespace Accounts_manager.Classes.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string OtherInfo { get; set; }
        public string DateCreated { get; set; }

        internal static AccountModel ParseRow(string row)
        {
            var columns = row.Split(',');
            AccountModel account = new AccountModel();
            account.Id = int.Parse(columns[0].Replace("\"", "").Replace("$#$", ","));
            account.SiteName = columns[1].Replace("\"", "").Replace("$#$", ",");
            account.Username = columns[2].Replace("\"", "").Replace("$#$", ",");
            account.Password = columns[3].Replace("\"", "").Replace("$#$", ",");
            account.Email = columns[4].Replace("\"", "").Replace("$#$", ",");
            account.Phone = columns[5].Replace("\"", "").Replace("$#$", ",");
            account.Question = columns[6].Replace("\"", "").Replace("$#$", ",");
            account.Answer = columns[7].Replace("\"", "").Replace(",", "$#$");
            account.OtherInfo = columns[8].Replace("\"", "").Replace("$#$", ",").Replace("~", "\n");
            account.DateCreated = DateTime.Parse(columns[9].Replace("\"", "")).ToString("yyyy/M/dd hh:mm tt");
            return account;
        }
    }
}
