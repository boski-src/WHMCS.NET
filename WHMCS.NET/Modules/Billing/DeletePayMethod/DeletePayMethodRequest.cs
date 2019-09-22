namespace WHMCS.NET.Modules.Billing.DeletePayMethod
{
    [RequestAction(ApiActions.DeletePayMethod)]
    public class DeletePayMethodRequest : BaseRequest
    {
        public int ClientId { get; set; }
        public int PayMethodId { get; set; }
    }
}