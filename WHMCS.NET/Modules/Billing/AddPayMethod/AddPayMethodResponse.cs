namespace WHMCS.NET.Modules.Billing.AddPayMethod
{
    public class AddPayMethodResponse : BaseResponse
    {
        public int ClientId { get; set; }
        public int PayMethodId { get; set; }
    }
}