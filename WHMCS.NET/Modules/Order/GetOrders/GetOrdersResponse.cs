namespace WHMCS.NET.Modules.Order.GetOrders
{
    public class GetOrdersResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public int StartNumber { get; set; }
        public int NumReturned { get; set; }
        public OrderArray Orders { get; set; }
    }
}