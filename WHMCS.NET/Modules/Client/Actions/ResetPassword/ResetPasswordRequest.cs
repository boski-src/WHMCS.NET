namespace WHMCS.NET.Modules.Client.Actions.ResetPassword
{
    [RequestAction(ApiActions.ResetPassword)]
    public class ResetPasswordRequest : BaseRequest
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}