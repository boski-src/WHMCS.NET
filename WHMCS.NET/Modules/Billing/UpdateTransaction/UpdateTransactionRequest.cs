using System;

namespace WHMCS.NET.Modules.Billing.UpdateTransaction
{
    [RequestAction(ApiActions.UpdateTransaction)]
    public class UpdateTransactionRequest : BaseRequest
    {
        public int TransactionIdId { get; set; }
        public int RefundId { get; set; }
        public int UserId { get; set; }
        public int InvoiceId { get; set; }
        public string TransId { get; set; }
        public DateTime Date { get; set; }
        public string Gateway { get; set; }
        public int Currency { get; set; }
        public string Description { get; set; }
        public decimal AmountIn { get; set; }
        public decimal Fees { get; set; }
        public decimal AmountOut { get; set; }
        public decimal Rate { get; set; }
        public bool Credit { get; set; }
    }
}