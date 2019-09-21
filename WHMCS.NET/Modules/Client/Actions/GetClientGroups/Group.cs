namespace WHMCS.NET.Modules.Client.Actions.GetClientGroups
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupColour { get; set; }
        public string DiscountPercent { get; set; }
        public string SuspTermExempt { get; set; }
        public string SeparateInvoices { get; set; }
    }
}