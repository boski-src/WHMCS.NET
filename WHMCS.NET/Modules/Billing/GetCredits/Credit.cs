using System;

namespace WHMCS.NET.Modules.Billing.GetCredits
{
    public class Credit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public int Relid { get; set; }
    }
}