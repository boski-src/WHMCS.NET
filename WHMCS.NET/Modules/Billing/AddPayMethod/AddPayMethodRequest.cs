namespace WHMCS.NET.Modules.Billing.AddPayMethod
{
    [RequestAction(ApiActions.AddPayMethod)]
    public class AddPayMethodRequest : BaseRequest
    {
        public int ClientId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Gateway_Module_Name { get; set; }
        public string Card_Number { get; set; }
        public string Card_Expiry { get; set; }
        public string Card_Start { get; set; }
        public int Card_Issue_Number { get; set; }
        public string Bank_Name { get; set; }
        public string Bank_Account_Type { get; set; }
        public string Bank_Code { get; set; }
        public string Bank_Account { get; set; }
        public bool Set_As_Default { get; set; }
    }
}