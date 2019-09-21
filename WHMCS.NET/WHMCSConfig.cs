namespace WHMCS.NET
{
    public class WHMCSConfig
    {
        public string Url { get; set; }
        public string AuthType { get; set; }
        public APICredentials ApiCredentials { get; set; }
        public LoginCredentials LoginCredentials { get; set; }

        public WHMCSConfig(string url, APICredentials apiCredentials)
        {
            Url = url;
            AuthType = AuthTypes.API;
            ApiCredentials = apiCredentials;
        }

        public WHMCSConfig(string url, LoginCredentials loginCredentials)
        {
            Url = url;
            AuthType = AuthTypes.API;
            LoginCredentials = loginCredentials;
        }
    }
}