namespace WHMCS.NET.Modules.Order.AddOrder
{
    public class AddOrderResponse : BaseResponse
    {
        public int OrderId { get; set; }
        public string ServiceIds { get; set; }
        public string AddonIds { get; set; }
        public string DomainIds { get; set; }
        public int InvoiceId { get; set; }
    }
}