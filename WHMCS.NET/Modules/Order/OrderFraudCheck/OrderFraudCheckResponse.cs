namespace WHMCS.NET.Modules.Order.OrderFraudCheck
{
    public class OrderFraudCheckResponse : BaseResponse
    {
        public string Status { get; set; }
        public string Module { get; set; }
        public string Results { get; set; }
    }
}