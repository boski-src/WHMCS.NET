using System;

namespace WHMCS.NET.Modules.Client.Actions.GetContacts
{
    public class Contact
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public bool SubAccount { get; set; }
        public string Password { get; set; }
        public string Permissions { get; set; }
        public int DomainEmails { get; set; }
        public int GeneralEmails { get; set; }
        public int InvoiceEmails { get; set; }
        public int ProductEmails { get; set; }
        public int SupportEmails { get; set; }
        public int AffiliateEmails { get; set; }
        public string PwResetKey { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime PwresetExpiry { get; set; }
    }
}