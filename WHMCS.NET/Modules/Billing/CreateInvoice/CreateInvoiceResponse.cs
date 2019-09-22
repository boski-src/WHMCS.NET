namespace WHMCS.NET.Modules.Billing.CreateInvoice
{
    public class CreateInvoiceResponse : BaseResponse
    {
        public int InvoiceId { get; set; }
        public string Status { get; set; }
    }
}