namespace WHMCS.NET.Modules.Client.Actions.GetClientsProducts
{
    [RequestAction(ApiActions.GetClientsProducts)]
    public class GetClientsProductsRequest : BaseRequest
    {
        public int LimitStart { get; set; }
        public int LimitNum { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public int Pid { get; set; }
        public string Domain { get; set; }
        public string Username2 { get; set; }
    }
}