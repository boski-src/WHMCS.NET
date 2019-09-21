namespace WHMCS.NET.Modules.Client.Actions.GetClientsAddons
{
    [RequestAction(ApiActions.GetClientsAddons)]
    public class GetClientsAddonsRequest : BaseRequest
    {
        public int ServiceId { get; set; }
        public int ClientId { get; set; }
        public int AddonId { get; set; }
    }
}