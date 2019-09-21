namespace WHMCS.NET.Modules.Order.GetOrders
{
    public class OrderItem
    {
        public string Type { get; set; }
        public int RelId { get; set; }
        public string ProducType { get; set; }
        public string Product { get; set; }
        public string Domain { get; set; }
        public string BillingCycle { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
    }
}