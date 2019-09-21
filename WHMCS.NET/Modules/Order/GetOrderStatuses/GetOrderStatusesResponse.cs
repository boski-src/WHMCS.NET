namespace WHMCS.NET.Modules.Order.GetOrderStatuses
{
    public class GetOrderStatusesResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public StatusArray Statuses { get; set; }
    }
}