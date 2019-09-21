namespace WHMCS.NET.Modules.Client.Actions.GetClientsDetails
{
    public class GetClientsDetailsResponse : BaseResponse
    {
        public Client Client { get; set; }
        public Stats Stats { get; set; }
    }
}