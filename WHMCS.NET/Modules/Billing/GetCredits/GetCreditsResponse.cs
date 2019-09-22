namespace WHMCS.NET.Modules.Billing.GetCredits
{
    public class GetCreditsResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public int ClientId { get; set; }
        public CreditArray Credits { get; set; }
    }
}