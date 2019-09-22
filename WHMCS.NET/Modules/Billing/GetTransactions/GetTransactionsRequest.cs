namespace WHMCS.NET.Modules.Billing.GetTransactions
{
    [RequestAction(ApiActions.GetTransactions)]
    public class GetTransactionsRequest : BaseRequest
    {
        public int InvoiceId { get; set; }
        public int ClientId { get; set; }
        public string TransId { get; set; }
    }
}