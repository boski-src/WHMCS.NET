namespace WHMCS.NET
{
    public class WHMCSConfig
    {
        public string Url { get; set; }
        public string AuthType { get; set; }
        public APICredentials ApiCredentials { get; set; }
        public LoginCredentials LoginCredentials { get; set; }
        public bool ThrowErrors { get; set; }

        protected WHMCSConfig(string url, bool throwErrors)
        {
            Url = url;
            ThrowErrors = throwErrors;
        }

        public WHMCSConfig(string url, APICredentials apiCredentials, bool throwErrors = false)
            : this(url, throwErrors)
        {
            AuthType = AuthTypes.API;
            ApiCredentials = apiCredentials;
        }

        public WHMCSConfig(string url, LoginCredentials loginCredentials, bool throwErrors = false)
            : this(url, throwErrors)
        {
            AuthType = AuthTypes.API;
            LoginCredentials = loginCredentials;
        }
    }
}