namespace WHMCS.NET.Modules.Billing.GetPayMethods
{
    public class PayMethod
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string GatewayName { get; set; }
        public string ContactType { get; set; }
        public int ContactId { get; set; }
        public int CardLastFour { get; set; }
        public string ExpiryDate { get; set; }
        public string StartDate { get; set; }
        public string IssueNumber { get; set; }
        public string CardType { get; set; }
        public string RemoteToken { get; set; }
        public string LastUpdated { get; set; }
    }
}