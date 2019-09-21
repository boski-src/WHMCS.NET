namespace WHMCS.NET.Modules.Client.Actions.GetClientsDomains
{
    public class Domain
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string RegType { get; set; }
        public string DomainName { get; set; }
        public string Registrar { get; set; }
        public string RegPeriod { get; set; }
        public string FirstPaymentAmount { get; set; }
        public string RecurringAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public string RegDate { get; set; }
        public string ExpiryDate { get; set; }
        public string NextDueDate { get; set; }
        public string Status { get; set; }
        public string SubscriptionId { get; set; }
        public string Promoid { get; set; }
        public string DnsManagement { get; set; }
        public string EmailForwarding { get; set; }
        public string IdProtection { get; set; }
        public string DoNotRenew { get; set; }
        public string Notes { get; set; }
    }
}