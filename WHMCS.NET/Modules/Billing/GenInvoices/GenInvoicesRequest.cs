namespace WHMCS.NET.Modules.Billing.GenInvoices
{
    [RequestAction(ApiActions.GenInvoices)]
    public class GenInvoicesRequest : BaseRequest
    {
        public bool NoEmails { get; set; }
        public int ClientId { get; set; }
        public int[] ServiceIds { get; set; }
        public int[] DomainIds { get; set; }
        public int[] AddonIds { get; set; }
    }
}