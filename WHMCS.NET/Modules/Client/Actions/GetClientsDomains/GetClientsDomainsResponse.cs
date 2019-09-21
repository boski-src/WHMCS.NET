namespace WHMCS.NET.Modules.Client.Actions.GetClientsDomains
{
    public class GetClientsDomainsResponse : BaseResponse
    {
        public int ClientId { get; set; }
        public int DomainId { get; set; }
        public int TotalResults { get; set; }
        public int StartNumber { get; set; }
        public int NumReturned { get; set; }
        public DomainArray Domains { get; set; }
    }
}