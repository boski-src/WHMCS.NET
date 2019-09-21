namespace WHMCS.NET.Modules.Client.Actions.AddClient
{
    [RequestAction(ApiActions.AddClient)]
    public class AddClientRequest : BaseRequest
    {
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
        public string Tax_Id { get; set; }
        public string Password2 { get; set; }
        public int SecurityqId { get; set; }
        public string SecurityqAns { get; set; }
        public int Currency { get; set; }
        public int GroupId { get; set; }
        public string CustomFields { get; set; }
        public string Language { get; set; }
        public string ClientIp { get; set; }
        public string Notes { get; set; }
        public bool MarketingOptIn { get; set; }
        public bool NoEmail { get; set; }
        public bool SkipValidation { get; set; }
    }
}