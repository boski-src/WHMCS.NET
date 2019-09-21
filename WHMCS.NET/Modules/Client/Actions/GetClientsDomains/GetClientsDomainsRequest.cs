namespace WHMCS.NET.Modules.Client.Actions.GetClientsDomains
{
    [RequestAction(ApiActions.GetClientsDomains)]
    public class GetClientsDomainsRequest : BaseRequest
    {
        public int LimitStart { get; set; } = 0;
        public int LimitNum { get; set; } = 25;
        public int ClientId { get; set; }
        public int DomainId { get; set; }
        public string Domain { get; set; }
    }
}