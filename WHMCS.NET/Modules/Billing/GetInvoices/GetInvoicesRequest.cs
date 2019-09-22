namespace WHMCS.NET.Modules.Billing.GetInvoices
{
    [RequestAction(ApiActions.GetInvoices)]
    public class GetInvoicesRequest : BaseRequest
    {
        public int LimitStart { get; set; }
        public int LimitNum { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public string OrderBy { get; set; }
        public string Order { get; set; }
    }
}