namespace WHMCS.NET.Modules.Auth
{
    [RequestAction(ApiActions.ValidateLogin)]
    public class ValidateLoginRequest : BaseRequest
    {
        public string Email { get; set; }
        public string Password2 { get; set; }
    }
}