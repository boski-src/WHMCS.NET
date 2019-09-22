namespace WHMCS.NET.Modules.Billing.GetInvoices
{
    public class Item
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Relid { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public int Taxed { get; set; }
    }
}