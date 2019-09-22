namespace WHMCS.NET.Modules.Billing.GetCredits
{
    [RequestAction(ApiActions.GetCredits)]
    public class GetCreditsRequest : BaseRequest
    {
        public int ClientId { get; set; }
    }
}