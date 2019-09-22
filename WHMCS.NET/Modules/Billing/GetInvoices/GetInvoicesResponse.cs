using System;

namespace WHMCS.NET.Modules.Billing.GetInvoices
{
    public class GetInvoicesResponse : BaseResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string InvoiceNum { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public string DatePaid { get; set; }
        public string SubTotal { get; set; }
        public string Credit { get; set; }
        public string Tax { get; set; }
        public string Tax2 { get; set; }
        public string Total { get; set; }
        public string TaxRate { get; set; }
        public string TaxRate2 { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public string Notes { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyPrefix { get; set; }
        public string CurrencySuffix { get; set; }
    }
}