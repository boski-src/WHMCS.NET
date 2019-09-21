namespace WHMCS.NET.Modules.Order.GetProducts
{
    public class GetProductsResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public int StartNumber { get; set; }
        public int NumReturned { get; set; }
        public ProductArray Products { get; set; }
    }
}