namespace WHMCS.NET.Modules.Client.Actions.GetClientsDetails
{
    [RequestAction(ApiActions.GetClientsDetails)]
    public class GetClientsDetailsRequest : BaseRequest
    {
        public int ClientId { get; set; }
        public string Email { get; set; }
        public bool Stats { get; set; }
    }
}