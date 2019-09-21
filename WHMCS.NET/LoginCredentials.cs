namespace WHMCS.NET
{
    public class LoginCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}