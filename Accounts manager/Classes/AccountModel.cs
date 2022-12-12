namespace Accounts_manager.Classes
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
    }
}
