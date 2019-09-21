using System;

namespace WHMCS.NET.Modules.Order.GetOrders
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNum { get; set; }
        public int UserId { get; set; }
        public int ContactId { get; set; }
        public DateTime Date { get; set; }
        public string NameServers { get; set; }
        public string TransferSecret { get; set; }
        public string Renewals { get; set; }
        public string PromoCode { get; set; }
        public string PromoType { get; set; }
        public string PromoValue { get; set; }
        public string OrderData { get; set; }
        public string Amount { get; set; }
        public string PaymentMethod { get; set; }
        public int InvoiceId { get; set; }
        public string Status { get; set; }
        public string IpAddress { get; set; }
        public string FraudModule { get; set; }
        public string FraudOutput { get; set; }
        public string Notes { get; set; }
        public string PaymentMethodName { get; set; }
        public string PaymentStatus { get; set; }
        public string Name { get; set; }
        public string CurrencyPrefix { get; set; }
        public string CurrencySuffix { get; set; }
        public string FraudData { get; set; }
        public OrderItemArray LineItems { get; set; }
    }
}