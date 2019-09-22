namespace WHMCS.NET.Modules.Billing.ApplyCredit
{
    [RequestAction(ApiActions.ApplyCredit)]
    public class ApplyCreditRequest : BaseRequest
    {
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public bool NoEmail { get; set; }
    }
}