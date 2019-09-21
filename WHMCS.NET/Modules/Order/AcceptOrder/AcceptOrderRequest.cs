namespace WHMCS.NET.Modules.Order.AcceptOrder
{
    [RequestAction(ApiActions.AcceptOrder)]
    public class AcceptOrderRequest : BaseRequest
    {
        public int OrderId { get; set; }
        public int ServerId { get; set; }
        public string ServiceUsername { get; set; }
        public string ServicePassword { get; set; }
        public string Registrar { get; set; }
        public bool SendRegistrar { get; set; }
        public bool AutoSetup { get; set; }
        public bool SendEmail { get; set; }
    }
}