namespace WHMCS.NET
{
    public class APICredentials
    {
        public string Identifier { get; set; }
        public string Secret { get; set; }

        public APICredentials(string identifier, string secret)
        {
            Identifier = identifier;
            Secret = secret;
        }
    }
}