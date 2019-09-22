using System;

namespace WHMCS.NET.Modules.Billing.GetInvoice
{
    public class GetInvoiceResponse : BaseResponse
    {
        public int InvoiceId { get; set; }
        public string InvoicEnum { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public string DatePaid { get; set; }
        public string SubTotal { get; set; }
        public string Credit { get; set; }
        public string Tax { get; set; }
        public string Tax2 { get; set; }
        public string Total { get; set; }
        public string Balance { get; set; }
        public string TaxRate { get; set; }
        public string TaxRate2 { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public string Notes { get; set; }
        public string CCGateway { get; set; }
        public ItemArray Items { get; set; }
        public string Transactions { get; set; }
    }
}