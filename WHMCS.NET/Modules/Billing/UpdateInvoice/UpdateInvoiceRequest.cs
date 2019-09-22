using System;

namespace WHMCS.NET.Modules.Billing.UpdateInvoice
{
    [RequestAction(ApiActions.UpdateInvoice)]
    public class UpdateInvoiceRequest : BaseRequest
    {
        public int InvoiceId { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxRate2 { get; set; }
        public decimal Credit { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DatePaid { get; set; }
        public string Notes { get; set; }
        public bool Publish { get; set; }
        public bool PublishAndSendEmail { get; set; }
    }
}