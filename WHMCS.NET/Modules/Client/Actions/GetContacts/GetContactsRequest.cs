namespace WHMCS.NET.Modules.Client.Actions.GetContacts
{
    [RequestAction(ApiActions.GetContacts)]
    public class GetContactsRequest : BaseRequest
    {
        public int LimitStart { get; set; }
        public int LimitNum { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public bool SubAccount { get; set; }
    }
}