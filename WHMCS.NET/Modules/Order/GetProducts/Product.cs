namespace WHMCS.NET.Modules.Order.GetProducts
{
    public class Product
    {
        public string Pid { get; set; }
        public string Gid { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Module { get; set; }
        public string PayType { get; set; }
        public ProductPricing Pricing { get; set; }
    }
}