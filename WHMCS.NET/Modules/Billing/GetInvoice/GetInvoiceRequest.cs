namespace WHMCS.NET.Modules.Billing.GetInvoice
{
    [RequestAction(ApiActions.GetInvoice)]
    public class GetInvoiceRequest : BaseRequest
    {
        public int InvoiceId { get; set; }
    }
}