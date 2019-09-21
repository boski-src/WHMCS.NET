namespace WHMCS.NET.Modules.Client.Actions.GetEmails
{
    public class GetEmailsResponse : BaseResponse
    {
        public int TotalResults { get; set; }
        public int StartNumber { get; set; }
        public int NumReturned { get; set; }
        public EmailArray Contacts { get; set; }
    }
}