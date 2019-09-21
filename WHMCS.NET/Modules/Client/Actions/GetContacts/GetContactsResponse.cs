namespace WHMCS.NET.Modules.Client.Actions.GetContacts
{
    public class GetContactsResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public int StartNumber { get; set; }
        public int NumReturned { get; set; }
        public ContactArray Contacts { get; set; }
    }
}