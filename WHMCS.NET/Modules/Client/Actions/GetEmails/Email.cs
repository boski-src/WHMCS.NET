using System;

namespace WHMCS.NET.Modules.Client.Actions.GetEmails
{
    public class Email
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
    }
}