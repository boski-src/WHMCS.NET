namespace WHMCS.NET.Modules.Client.Actions.CloseClient
{
    [RequestAction(ApiActions.CloseClient)]
    public class CloseClientRequest : BaseRequest
    {
        public int ClientId { get; set; }
    }
}