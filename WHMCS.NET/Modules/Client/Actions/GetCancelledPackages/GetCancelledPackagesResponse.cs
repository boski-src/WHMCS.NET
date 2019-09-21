namespace WHMCS.NET.Modules.Client.Actions.GetCancelledPackages
{
    public class GetCancelledPackagesResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public int StartNumber { get; set; }
        public int NumReturned { get; set; }
        public PackageArray Packages { get; set; }
    }
}