namespace WHMCS.NET.Modules.Billing.CapturePayment
{
    [RequestAction(ApiActions.CapturePayment)]
    public class CapturePaymentRequest : BaseRequest
    {
        public int InvoiceId { get; set; }
        public string CVV { get; set; }
    }
}