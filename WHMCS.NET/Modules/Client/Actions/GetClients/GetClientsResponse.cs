namespace WHMCS.NET.Modules.Client.Actions.GetClients
{
    public class GetClientsResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public int StartNumber { get; set; }
        public int NumReturned { get; set; }
        public ClientsArray Clients { get; set; }
    }
}