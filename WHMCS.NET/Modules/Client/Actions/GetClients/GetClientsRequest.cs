namespace WHMCS.NET.Modules.Client.Actions.GetClients
{
    [RequestAction(ApiActions.GetClients)]
    public class GetClientsRequest : BaseRequest
    {
        public int LimitStart { get; set; }
        public int LimitNum { get; set; }
        public string Sorting { get; set; }
        public string Search { get; set; }
    }
}