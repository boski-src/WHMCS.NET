using System;

namespace WHMCS.NET.Modules.Client.Actions.GetClientsAddons
{
    public class Addon
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public int ServiceId { get; set; }
        public int AddonId { get; set; }
        public string Name { get; set; }
        public decimal SetupFee { get; set; }
        public decimal Recurring { get; set; }
        public string BillingCycle { get; set; }
        public decimal Tax { get; set; }
        public string Status { get; set; }
        public DateTime regdate { get; set; }
        public DateTime nextduedate { get; set; }
        public DateTime nextinvoicedate { get; set; }
        public string paymentmethod { get; set; }
        public string notes { get; set; }
    }
}