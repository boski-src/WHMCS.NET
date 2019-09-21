namespace WHMCS.NET.Modules.Client.Actions.DeleteContact
{
    [RequestAction(ApiActions.DeleteContact)]
    public class DeleteContactRequest : BaseRequest
    {
        public int ContactId { get; set; }
    }
}