namespace WHMCS.NET.Modules.Client.Actions.GetClientsProducts
{
    public class Product
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public string OrderId { get; set; }
        public string Pid { get; set; }
        public string Regdate { get; set; }
        public string Name { get; set; }
        public string Translated_Name { get; set; }
        public string GroupName { get; set; }
        public string Translated_GroupName { get; set; }
        public string Domain { get; set; }
        public string DedicatedIp { get; set; }
        public string ServerId { get; set; }
        public string ServerName { get; set; }
        public string ServerIp { get; set; }
        public string ServerhostName { get; set; }
        public string SuspensionReason { get; set; }
        public string FirstpaymentAmount { get; set; }
        public string RecurringAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public string BillingCycle { get; set; }
        public string NextDueDate { get; set; }
        public string Status { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SubscriptionId { get; set; }
        public string PromoId { get; set; }
        public string OverIdeAutoSuspend { get; set; }
        public string OverIdeSuspendUntil { get; set; }
        public string NS1 { get; set; }
        public string NS2 { get; set; }
        public string AssignedOps { get; set; }
        public string Notes { get; set; }
        public string DiskUsage { get; set; }
        public string DiskLimit { get; set; }
        public string BwUsage { get; set; }
        public string BwLimit { get; set; }
        public string LastUpdate { get; set; }
    }
}