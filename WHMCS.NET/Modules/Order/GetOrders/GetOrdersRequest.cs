namespace WHMCS.NET.Modules.Order.GetOrders
{
    [RequestAction(ApiActions.GetOrders)]
    public class GetOrdersRequest : BaseRequest
    {
        public int LimitStart { get; set; }
        public int LimitNum { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
    }
}