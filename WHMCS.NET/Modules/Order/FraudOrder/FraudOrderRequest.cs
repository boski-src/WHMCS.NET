namespace WHMCS.NET.Modules.Order.FraudOrder
{
    [RequestAction(ApiActions.FraudOrder)]
    public class FraudOrderRequest : BaseRequest
    {
        public int OrderId { get; set; }
        public bool CancelSub { get; set; }
    }
}