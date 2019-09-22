namespace WHMCS.NET.Modules.Billing.GenInvoices
{
    public class GenInvoicesResponse : BaseResponse
    {
        public int NumCreated { get; set; }
        public int LatestInvoiceId { get; set; }
    }
}