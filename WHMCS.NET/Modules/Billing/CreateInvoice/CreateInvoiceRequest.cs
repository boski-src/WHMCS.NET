using System;

namespace WHMCS.NET.Modules.Billing.CreateInvoice
{
    [RequestAction(ApiActions.CreateInvoice)]
    public class CreateInvoiceRequest : BaseRequest
    {
        public int UserId { get; set; }
        public string Status { get; set; }
        public bool Draft { get; set; }
        public bool SendInvoice { get; set; }
        public string PaymentMethod { get; set; }
        public float TaxRate { get; set; }
        public float TaxRate2 { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public string Notes { get; set; }

        // Inherit class to add more items 
        public string ItemDescription1 { get; set; }
        public decimal ItemAmount1 { get; set; }
        public bool ItemTaxed1 { get; set; }

        public bool AutoApplyCredit { get; set; }
    }
}