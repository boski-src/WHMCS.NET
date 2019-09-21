namespace WHMCS.NET.Modules.Client.Actions.GetClientsDetails
{
    public class Stats
    {
        public int NumDueInvoices { get; set; }
        public string DueInvoicesBalance { get; set; }
        public string InCome { get; set; }
        public bool InCredit { get; set; }
        public string CreditBalance { get; set; }
        public int NumOverdueInvoices { get; set; }
        public string OverdueInvoicesBalance { get; set; }
        public int NumDraftInvoices { get; set; }
        public string DraftInvoicesBalance { get; set; }
        public int NumPaidInvoices { get; set; }
        public string PaidInvoicesAmount { get; set; }
        public int NumUnpaidInvoices { get; set; }
        public string UnpaidInvoicesAmount { get; set; }
        public int NumcancelledInvoices { get; set; }
        public string CancelledInvoicesAmount { get; set; }
        public int NumRefundedInvoices { get; set; }
        public string RefundedInvoicesAmount { get; set; }
        public int NumCollectionsInvoices { get; set; }
        public string CollectionsInvoicesAmount { get; set; }
        public int ProductsNumactiveHosting { get; set; }
        public int ProductsNumHosting { get; set; }
        public int ProductsNumActiveReseller { get; set; }
        public int ProductsNumReseller { get; set; }
        public int ProductsNumActiveServers { get; set; }
        public int ProductsNumServers { get; set; }
        public int ProductsNumActiveother { get; set; }
        public int ProductsNumOther { get; set; }
        public int ProductsNumActive { get; set; }
        public int ProductsNumTotal { get; set; }
        public int NumActiveDomains { get; set; }
        public int NumDomains { get; set; }
        public int NumAcceptedQuotes { get; set; }
        public int NumQuotes { get; set; }
        public int NumTickets { get; set; }
        public int NumActiveTickets { get; set; }
        public int NumAffiliateSignups { get; set; }
        public bool IsAffiliate { get; set; }
    }
}