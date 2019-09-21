namespace WHMCS.NET
{
    public enum ApiActions
    {
        // Client
        ValidateLogin,
        AddClient,
        AddContact,
        CloseClient,
        DeleteClient,
        DeleteContact,
        GetCancelledPackages,
        GetClientGroups,
        GetClientPassword,
        GetClients,
        GetClientsAddons,
        GetClientsDetails,
        GetClientsDomains,
        GetClientsProducts,
        GetContacts,
        GetEmails,
        ResetPassword,
        UpdateClient,
        UpdateContact,

        // Order
        AcceptOrder,
        AddOrder,
        CancelOrder,
        DeleteOrder,
        FraudOrder,
        GetOrders,
        GetOrderStatuses,
        GetProducts,
        GetPromotions,
        OrderFraudCheck,
        PendingOrder
    }
}