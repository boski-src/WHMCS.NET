namespace WHMCS.NET.Modules.Order.OrderFraudCheck
{
    [RequestAction(ApiActions.OrderFraudCheck)]
    public class OrderFraudCheckRequest : BaseRequest
    {
        public int OrderId { get; set; }
        public string IpAddress { get; set; }
    }
}