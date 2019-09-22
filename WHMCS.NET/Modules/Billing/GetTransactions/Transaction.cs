using System;

namespace WHMCS.NET.Modules.Billing.GetTransactions
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Currency { get; set; }
        public string Gateway { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string AmountIn { get; set; }
        public string Fees { get; set; }
        public string AmountOut { get; set; }
        public string Rate { get; set; }
        public string TransId { get; set; }
        public int InvoiceId { get; set; }
        public int RefundId { get; set; }
    }
}