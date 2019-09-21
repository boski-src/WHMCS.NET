namespace WHMCS.NET.Modules.Order.AddOrder
{
    [RequestAction(ApiActions.AddOrder)]
    public class AddOrderRequest : BaseRequest
    {
        public int ClientId { get; set; }
        public string PaymentMethod { get; set; }
        public int[] Pid { get; set; }
        public string[] Domain { get; set; }
        public string[] BillingCycle { get; set; }
        public string[] DomainType { get; set; }
        public int[] Regperiod { get; set; }
        public string[] EppCode { get; set; }
        public string NameServer1 { get; set; }
        public string NameServer2 { get; set; }
        public string NameServer3 { get; set; }
        public string NameServer4 { get; set; }
        public string NameServer5 { get; set; }
        public string[] CustomFields { get; set; }
        public string[] ConfigOptions { get; set; }
        public float[] PriceOverride { get; set; }
        public string PromoCode { get; set; }
        public bool PromoOverride { get; set; }
        public int AffId { get; set; }
        public bool NoInvoice { get; set; }
        public bool NoInvoiceEmail { get; set; }
        public bool NoEmail { get; set; }
        public string[] Addons { get; set; }
        public string[] Hostname { get; set; }
        public string[] NS1Prefix { get; set; }
        public string[] NS2Prefix { get; set; }
        public string[] RootPW { get; set; }
        public int ContactId { get; set; }
        public bool[] DNSManagement { get; set; }
        public string[] DomainFields { get; set; }
        public bool[] EmailForwarding { get; set; }
        public bool[] IdProtection { get; set; }
        public float[] DomainPriceOverride { get; set; }
        public object[] DomainRenewals { get; set; }
        public string ClientIp { get; set; }
        public int AddonId { get; set; }
        public int ServiceId { get; set; }
        public int[] AddonIds { get; set; }
        public int[] ServiceIds { get; set; }
    }
}