namespace WHMCS.NET.Modules.Billing.GetPayMethods
{
    public class GetPayMethodsResponse : BaseResponse
    {
        public int ClientId { get; set; }
        public PayMethod[] PayMethods { get; set; }
    }
}