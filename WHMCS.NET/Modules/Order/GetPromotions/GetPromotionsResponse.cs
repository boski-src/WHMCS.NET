namespace WHMCS.NET.Modules.Order.GetPromotions
{
    public class GetPromotionsResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public PromotionArray Promotions { get; set; }
    }
}