namespace WHMCS.NET.Modules.Client.Actions.GetClientsAddons
{
    public class GetClientsAddonsResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public int ServiceId { get; set; }
        public int ClientId { get; set; }
        public AddonsArray Addons { get; set; }
    }
}