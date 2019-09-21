using System.Threading.Tasks;
using WHMCS.NET.Modules.Client.Actions.AddClient;
using WHMCS.NET.Modules.Client.Actions.AddContact;
using WHMCS.NET.Modules.Client.Actions.CloseClient;
using WHMCS.NET.Modules.Client.Actions.DeleteClient;
using WHMCS.NET.Modules.Client.Actions.DeleteContact;
using WHMCS.NET.Modules.Client.Actions.GetCancelledPackages;
using WHMCS.NET.Modules.Client.Actions.GetClientGroups;
using WHMCS.NET.Modules.Client.Actions.GetClientPassword;
using WHMCS.NET.Modules.Client.Actions.GetClients;
using WHMCS.NET.Modules.Client.Actions.GetClientsAddons;
using WHMCS.NET.Modules.Client.Actions.GetClientsDetails;
using WHMCS.NET.Modules.Client.Actions.GetClientsDomains;
using WHMCS.NET.Modules.Client.Actions.GetClientsProducts;
using WHMCS.NET.Modules.Client.Actions.GetContacts;
using WHMCS.NET.Modules.Client.Actions.GetEmails;
using WHMCS.NET.Modules.Client.Actions.ResetPassword;
using WHMCS.NET.Modules.Client.Actions.UpdateClient;
using WHMCS.NET.Modules.Client.Actions.UpdateContact;

namespace WHMCS.NET.Modules.Client
{
    public class ClientModule : Module
    {
        public async Task<AddClientResponse> Add(AddClientRequest request)
        {
            return await Client.Execute<AddClientRequest, AddClientResponse>(request);
        }

        public async Task<CloseClientResponse> Close(int clientId)
        {
            var request = new CloseClientRequest { ClientId = clientId };
            return await Client.Execute<CloseClientRequest, CloseClientResponse>(request);
        }

        public async Task<DeleteClientResponse> Delete(int clientId)
        {
            var request = new DeleteClientRequest { ClientId = clientId };
            return await Client.Execute<DeleteClientRequest, DeleteClientResponse>(request);
        }

        public async Task<AddContactResponse> AddContact(AddContactRequest request)
        {
            return await Client.Execute<AddContactRequest, AddContactResponse>(request);
        }

        public async Task<DeleteContactResponse> DeleteContact(int contactId)
        {
            var request = new DeleteContactRequest { ContactId = contactId };
            return await Client.Execute<DeleteContactRequest, DeleteContactResponse>(request);
        }

        public async Task<GetCancelledPackagesResponse> GetCancelledPackages(int limitStart, int limitNum)
        {
            var request = new GetCancelledPackagesRequest {
                LimitStart = limitStart,
                LimitNum = limitNum
            };
            return await Client.Execute<GetCancelledPackagesRequest, GetCancelledPackagesResponse>(request);
        }

        public async Task<GetClientGroupsResponse> BrowseGroups()
        {
            var request = new GetClientGroupsRequest();
            return await Client.Execute<GetClientGroupsRequest, GetClientGroupsResponse>(request);
        }

        public async Task<GetClientPasswordResponse> GetPassword(int userId)
        {
            var request = new GetClientPasswordRequest {
                UserId = userId
            };
            return await Client.Execute<GetClientPasswordRequest, GetClientPasswordResponse>(request);
        }

        public async Task<GetClientPasswordResponse> GetPassword(string email)
        {
            var request = new GetClientPasswordRequest {
                Email = email
            };
            return await Client.Execute<GetClientPasswordRequest, GetClientPasswordResponse>(request);
        }

        public async Task<GetClientsResponse> Browse(GetClientsRequest request = null)
        {
            request = request ?? new GetClientsRequest();
            return await Client.Execute<GetClientsRequest, GetClientsResponse>(request);
        }

        public async Task<GetClientsAddonsResponse> BrowseAddons(GetClientsAddonsRequest request = null)
        {
            request = request ?? new GetClientsAddonsRequest();
            return await Client.Execute<GetClientsAddonsRequest, GetClientsAddonsResponse>(request);
        }

        public async Task<GetClientsProductsResponse> BrowseProducts(GetClientsProductsRequest request = null)
        {
            request = request ?? new GetClientsProductsRequest();
            return await Client.Execute<GetClientsProductsRequest, GetClientsProductsResponse>(request);
        }

        public async Task<GetClientsDomainsResponse> BrowseDomains(GetClientsDomainsRequest request = null)
        {
            request = request ?? new GetClientsDomainsRequest();
            return await Client.Execute<GetClientsDomainsRequest, GetClientsDomainsResponse>(request);
        }

        public async Task<GetContactsResponse> BrowseContacts(GetContactsRequest request = null)
        {
            request = request ?? new GetContactsRequest();
            return await Client.Execute<GetContactsRequest, GetContactsResponse>(request);
        }

        public async Task<GetEmailsResponse> BrowseEmails(GetEmailsRequest request = null)
        {
            request = request ?? new GetEmailsRequest();
            return await Client.Execute<GetEmailsRequest, GetEmailsResponse>(request);
        }

        public async Task<ResetPasswordResponse> ResetPassword(int clientId)
        {
            var request = new ResetPasswordRequest {
                Id = clientId
            };
            return await Client.Execute<ResetPasswordRequest, ResetPasswordResponse>(request);
        }

        public async Task<ResetPasswordResponse> ResetPassword(string email)
        {
            var request = new ResetPasswordRequest {
                Email = email
            };
            return await Client.Execute<ResetPasswordRequest, ResetPasswordResponse>(request);
        }

        public async Task<UpdateClientResponse> Update(UpdateClientRequest request)
        {
            return await Client.Execute<UpdateClientRequest, UpdateClientResponse>(request);
        }

        public async Task<UpdateContactResponse> UpdateContact(UpdateContactRequest request)
        {
            return await Client.Execute<UpdateContactRequest, UpdateContactResponse>(request);
        }

        public async Task<GetClientsDetailsResponse> GetDetails(int clientId, bool stats = false)
        {
            var request = new GetClientsDetailsRequest {
                ClientId = clientId,
                Stats = stats
            };
            return await Client.Execute<GetClientsDetailsRequest, GetClientsDetailsResponse>(request);
        }

        public async Task<GetClientsDetailsResponse> GetDetails(string email, bool stats = false)
        {
            var request = new GetClientsDetailsRequest {
                Email = email,
                Stats = stats
            };
            return await Client.Execute<GetClientsDetailsRequest, GetClientsDetailsResponse>(request);
        }
    }
}