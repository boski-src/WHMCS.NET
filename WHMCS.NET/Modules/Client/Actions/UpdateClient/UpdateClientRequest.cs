namespace WHMCS.NET.Modules.Client.Actions.UpdateClient
{
    [RequestAction(ApiActions.UpdateClient)]
    public class UpdateClientRequest : BaseRequest
    {
        public int ClientId { get; set; }
        public string ClientEmail { get; set; }
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
        public string Password2 { get; set; }
        public string Currency { get; set; }
        public string CustomFields { get; set; }
        public string SecurityqId { get; set; }
        public string SecurityqAns { get; set; }
        public string GroupId { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public bool MarketingOptIn { get; set; }
        public bool ClearCreditCard { get; set; }
        public bool SkipValidation { get; set; }
        public string ClientIp { get; set; }
        public string Language { get; set; }
    }
}