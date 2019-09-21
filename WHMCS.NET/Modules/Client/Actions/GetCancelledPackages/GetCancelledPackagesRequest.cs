namespace WHMCS.NET.Modules.Client.Actions.GetCancelledPackages
{
    [RequestAction(ApiActions.GetCancelledPackages)]
    public class GetCancelledPackagesRequest : BaseRequest
    {
        public int LimitStart { get; set; }
        public int LimitNum { get; set; }
    }
}