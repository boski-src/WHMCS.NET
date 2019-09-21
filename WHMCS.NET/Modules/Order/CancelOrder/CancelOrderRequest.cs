namespace WHMCS.NET.Modules.Order.CancelOrder
{
    [RequestAction(ApiActions.CancelOrder)]
    public class CancelOrderRequest : BaseRequest
    {
        public int OrderId { get; set; }
        public bool CancelSub { get; set; }
        public bool NoEmail { get; set; }
    }
}