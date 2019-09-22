using System;

namespace WHMCS.NET.Modules.Billing.AddCredit
{
    [RequestAction(ApiActions.AddCredit)]
    public class AddCreditRequest : BaseRequest
    {
        public int ClientId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int AdminId { get; set; }
        public string Type { get; set; }
    }
}