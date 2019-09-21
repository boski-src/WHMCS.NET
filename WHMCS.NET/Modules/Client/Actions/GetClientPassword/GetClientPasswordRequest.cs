namespace WHMCS.NET.Modules.Client.Actions.GetClientPassword
{
    [RequestAction(ApiActions.GetClientPassword)]
    public class GetClientPasswordRequest : BaseRequest
    {
        public int UserId { get; set; }
        public string Email { get; set; }
    }
}