namespace WHMCS.NET.Modules.Order.GetPromotions
{
    public class Promotion
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public long Recurring { get; set; }
        public long Value { get; set; }
        public string Cycles { get; set; }
        public string AppliesTo { get; set; }
        public string Requires { get; set; }
        public long RequiresExisting { get; set; }
        public string StartDate { get; set; }
        public string ExpiratiOnDate { get; set; }
        public long MaxUses { get; set; }
        public long Uses { get; set; }
        public long LifeTimePromo { get; set; }
        public long ApplyOnce { get; set; }
        public long NewSignUps { get; set; }
        public long ExistingClient { get; set; }
        public long OnceperClient { get; set; }
        public long RecurFor { get; set; }
        public long Upgrades { get; set; }
        public string UpgradeConfig { get; set; }
        public string Notes { get; set; }
    }
}