namespace WHMCS.NET.Modules.Billing.ApplyCredit
{
    public class ApplyCreditResponse : BaseResponse
    {
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public bool InvoicePaid { get; set; }
    }
}