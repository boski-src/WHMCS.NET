namespace WHMCS.NET.Modules.Client.Actions.GetClientGroups
{
    public class GetClientGroupsResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public Group[] Groups { get; set; }
    }
}