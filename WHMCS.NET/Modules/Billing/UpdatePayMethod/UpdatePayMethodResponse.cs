namespace WHMCS.NET.Modules.Billing.UpdatePayMethod
{
    public class UpdatePayMethodResponse : BaseResponse
    {
        public int PaymethodId { get; set; }
        public int ClientId { get; set; }
    }
}