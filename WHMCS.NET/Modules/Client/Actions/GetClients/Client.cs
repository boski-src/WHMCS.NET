using System;

namespace WHMCS.NET.Modules.Client.Actions.GetClients
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public int GroupId { get; set; }
        public string Status { get; set; }
    }
}