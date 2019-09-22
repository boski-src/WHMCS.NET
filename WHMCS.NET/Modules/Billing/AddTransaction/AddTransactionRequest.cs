using System;

namespace WHMCS.NET.Modules.Billing.AddTransaction
{
    [RequestAction(ApiActions.AddTransaction)]
    public class AddTransactionRequest : BaseRequest
    {
        public string PaymentMethod { get; set; }
        public int UserId { get; set; }
        public int InvoiceId { get; set; }
        public string TransId { get; set; }
        public DateTime Date { get; set; }
        public int CurrencyId { get; set; }
        public string Description { get; set; }
        public decimal AmountIn { get; set; }
        public decimal Fees { get; set; }
        public decimal AmountOut { get; set; }
        public decimal Rate { get; set; }
        public bool Credit { get; set; }
        public bool AllowDuplicateTransId { get; set; }
    }
}