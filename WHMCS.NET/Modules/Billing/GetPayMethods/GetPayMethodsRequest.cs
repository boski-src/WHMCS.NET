namespace WHMCS.NET.Modules.Billing.GetPayMethods
{
    [RequestAction(ApiActions.GetPayMethods)]
    public class GetPayMethodsRequest : BaseRequest
    {
        public int ClientId { get; set; }
        public int PaymethodId { get; set; }
        public string Type { get; set; }
    }
}