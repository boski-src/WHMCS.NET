namespace WHMCS.NET.Modules.Order.GetPromotions
{
    [RequestAction(ApiActions.GetPromotions)]
    public class GetPromotionsRequest : BaseRequest
    {
        public string Code { get; set; }
    }
}