namespace WHMCS.NET.Modules.Auth
{
    public class ValidateLoginResponse : BaseResponse
    {
        public string UserId { get; set; }
        public string PasswordHash { get; set; }
        public string TwoFactorEnabled { get; set; }
    }
}