namespace WHMCS.NET.Modules.Client.Actions.GetClientsProducts
{
    public class GetClientsProductsResponse : BaseResponse
    {
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public int Pid { get; set; }
        public string Domain { get; set; }
        public int TotalResults { get; set; }
        public int StartNumber { get; set; }
        public int NumReturned { get; set; }
        public ProductArray Products { get; set; }
    }
}