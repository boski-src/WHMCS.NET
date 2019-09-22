namespace WHMCS.NET.Modules.Billing.AcceptQuote
{
    [RequestAction(ApiActions.AcceptQuote)]
    public class AcceptQuoteRequest : BaseRequest
    {
        public int QuoteId { get; set; }
    }
}