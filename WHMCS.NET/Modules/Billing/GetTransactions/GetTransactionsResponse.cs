namespace WHMCS.NET.Modules.Billing.GetTransactions
{
    public class GetTransactionsResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public int StartNumber { get; set; }
        public int NumReturned { get; set; }
        public TransactionArray Transactions { get; set; }
    }
}