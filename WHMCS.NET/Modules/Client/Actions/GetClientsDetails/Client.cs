namespace WHMCS.NET.Modules.Client.Actions.GetClientsDetails
{
    public class Client
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string FullState { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string StateCode { get; set; }
        public string CountryName { get; set; }
        public int PhoneCC { get; set; }
        public string PhonenumberFormatted { get; set; }
        public int BillingcId { get; set; }
        public string Notes { get; set; }
        public bool TwoFaEnabled { get; set; }
        public string Currency { get; set; }
        public string DefaultGateway { get; set; }
        public string SecurityqId { get; set; }
        public string SecurityqAns { get; set; }
        public string GroupId { get; set; }
        public string Status { get; set; }
        public decimal Credit { get; set; }
        public string TaxExempt { get; set; }
        public string LateFeeOveride { get; set; }
        public string OverideDueNotices { get; set; }
        public string SeparateInvoices { get; set; }
        public string DisableAutoCC { get; set; }
        public string EmailOptout { get; set; }
        public bool Marketing_Emails_Opt_In { get; set; }
        public string OverrideAutoClose { get; set; }
        public int AllowSingleSignOn { get; set; }
        public string Language { get; set; }
        public string LastLogin { get; set; }
        public string Currency_Code { get; set; }
    }
}