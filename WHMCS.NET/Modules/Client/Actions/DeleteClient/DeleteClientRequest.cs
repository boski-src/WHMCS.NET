namespace WHMCS.NET.Modules.Client.Actions.DeleteClient
{
    [RequestAction(ApiActions.DeleteClient)]
    public class DeleteClientRequest : BaseRequest
    {
        public int ClientId { get; set; }
    }
}