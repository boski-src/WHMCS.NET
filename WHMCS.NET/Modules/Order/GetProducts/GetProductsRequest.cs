namespace WHMCS.NET.Modules.Order.GetProducts
{
    [RequestAction(ApiActions.GetProducts)]
    public class GetProductsRequest : BaseRequest
    {
        public int Pid { get; set; }
        public int Gid { get; set; }
        public string Module { get; set; }
    }
}