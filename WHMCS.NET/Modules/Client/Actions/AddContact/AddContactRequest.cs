namespace WHMCS.NET.Modules.Client.Actions.AddContact
{
    [RequestAction(ApiActions.AddContact)]
    public class AddContactRequest : BaseRequest
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ComapnyName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Tax_Id { get; set; }
        public string Password2 { get; set; }
        public string Permissions { get; set; }
        public bool GeneralEmails { get; set; }
        public bool ProductEmails { get; set; }
        public bool DomainEmails { get; set; }
        public bool InvoiceEmails { get; set; }
        public bool SupportEmails { get; set; }
    }
}