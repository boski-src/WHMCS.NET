namespace WHMCS.NET.Modules.Order.PendingOrder
{
    [RequestAction(ApiActions.PendingOrder)]
    public class PendingOrderRequest : BaseRequest
    {
        public int OrderId { get; set; }
    }
}