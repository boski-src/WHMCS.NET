using System;

namespace WHMCS.NET.Modules.Client.Actions.GetEmails
{
    [RequestAction(ApiActions.GetEmails)]
    public class GetEmailsRequest : BaseRequest
    {
        public int LimitStart { get; set; }
        public int LimitNum { get; set; }
        public int ClientId { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
    }
}