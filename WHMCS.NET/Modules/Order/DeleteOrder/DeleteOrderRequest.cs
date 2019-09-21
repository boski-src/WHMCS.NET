namespace WHMCS.NET.Modules.Order.DeleteOrder
{
    [RequestAction(ApiActions.DeleteOrder)]
    public class DeleteOrderRequest : BaseRequest
    {
        public int OrderId { get; set; }
    }
}