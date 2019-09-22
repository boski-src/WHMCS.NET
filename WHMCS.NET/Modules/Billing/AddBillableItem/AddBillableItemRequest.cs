using System;

namespace WHMCS.NET.Modules.Billing.AddBillableItem
{
    [RequestAction(ApiActions.AddBillableItem)]
    public class AddBillableItemRequest : BaseRequest
    {
        public int ClientId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string InvoiceAction { get; set; }
        public int Recur { get; set; }
        public string RecurCycle { get; set; }
        public int RecurFor { get; set; }
        public DateTime DueDate { get; set; }
        public float Hours { get; set; }
    }
}