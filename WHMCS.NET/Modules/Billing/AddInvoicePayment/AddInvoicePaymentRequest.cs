using System;

namespace WHMCS.NET.Modules.Billing.AddInvoicePayment
{
    [RequestAction(ApiActions.AddInvoicePayment)]
    public class AddInvoicePaymentRequest : BaseRequest
    {
        public int InvoiceId { get; set; }
        public string TransIf { get; set; }
        public string Gateway { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal Fees { get; set; }
        public bool NoEmail { get; set; }
    }
}