using System.Threading.Tasks;
using WHMCS.NET.Modules.Billing.AcceptQuote;
using WHMCS.NET.Modules.Billing.AddBillableItem;
using WHMCS.NET.Modules.Billing.AddCredit;
using WHMCS.NET.Modules.Billing.AddInvoicePayment;
using WHMCS.NET.Modules.Billing.AddPayMethod;
using WHMCS.NET.Modules.Billing.AddTransaction;
using WHMCS.NET.Modules.Billing.ApplyCredit;
using WHMCS.NET.Modules.Billing.CapturePayment;
using WHMCS.NET.Modules.Billing.CreateInvoice;
using WHMCS.NET.Modules.Billing.DeletePayMethod;
using WHMCS.NET.Modules.Billing.GenInvoices;
using WHMCS.NET.Modules.Billing.GetCredits;
using WHMCS.NET.Modules.Billing.GetInvoice;
using WHMCS.NET.Modules.Billing.GetPayMethods;
using WHMCS.NET.Modules.Billing.GetQuotes;
using WHMCS.NET.Modules.Billing.UpdateInvoice;
using WHMCS.NET.Modules.Billing.UpdatePayMethod;
using WHMCS.NET.Modules.Billing.UpdateTransaction;

namespace WHMCS.NET.Modules.Billing
{
    public class BillingModule : Module
    {
        public async Task<AcceptQuoteResponse> AcceptQuote(int quoteId)
        {
            var request = new AcceptQuoteRequest { QuoteId = quoteId };
            return await Client.Execute<AcceptQuoteRequest, AcceptQuoteResponse>(request);
        }

        public async Task<AddBillableItemResponse> AddBillableItem(AddBillableItemRequest request)
        {
            return await Client.Execute<AddBillableItemRequest, AddBillableItemResponse>(request);
        }

        public async Task<AddCreditResponse> AddCredit(AddCreditRequest request)
        {
            return await Client.Execute<AddCreditRequest, AddCreditResponse>(request);
        }

        public async Task<AddInvoicePaymentResponse> AddInvoicePayment(AddInvoicePaymentRequest request)
        {
            return await Client.Execute<AddInvoicePaymentRequest, AddInvoicePaymentResponse>(request);
        }

        public async Task<AddPayMethodResponse> AddPayMethod(AddPayMethodRequest request)
        {
            return await Client.Execute<AddPayMethodRequest, AddPayMethodResponse>(request);
        }

        public async Task<AddTransactionResponse> AddTransaction(AddTransactionRequest request)
        {
            return await Client.Execute<AddTransactionRequest, AddTransactionResponse>(request);
        }

        public async Task<ApplyCreditResponse> ApplyCredit(ApplyCreditRequest request)
        {
            return await Client.Execute<ApplyCreditRequest, ApplyCreditResponse>(request);
        }

        public async Task<CapturePaymentResponse> CapturePayment(CapturePaymentRequest request)
        {
            return await Client.Execute<CapturePaymentRequest, CapturePaymentResponse>(request);
        }

        public async Task<CreateInvoiceResponse> CreateInvoice(CreateInvoiceRequest request)
        {
            return await Client.Execute<CreateInvoiceRequest, CreateInvoiceResponse>(request);
        }

        public async Task<DeletePayMethodResponse> DeletePayMethod(DeletePayMethodRequest request)
        {
            return await Client.Execute<DeletePayMethodRequest, DeletePayMethodResponse>(request);
        }

        public async Task<GenInvoicesResponse> GenInvoices(GenInvoicesRequest request)
        {
            return await Client.Execute<GenInvoicesRequest, GenInvoicesResponse>(request);
        }

        public async Task<UpdateInvoiceResponse> UpdateInvoice(UpdateInvoiceRequest request)
        {
            return await Client.Execute<UpdateInvoiceRequest, UpdateInvoiceResponse>(request);
        }

        public async Task<UpdatePayMethodResponse> UpdatePayMethod(UpdatePayMethodRequest request)
        {
            return await Client.Execute<UpdatePayMethodRequest, UpdatePayMethodResponse>(request);
        }

        public async Task<UpdateTransactionResponse> UpdateTransaction(UpdateTransactionRequest request)
        {
            return await Client.Execute<UpdateTransactionRequest, UpdateTransactionResponse>(request);
        }

        public async Task<GetCreditsResponse> GetCredits(int clientId)
        {
            var request = new GetCreditsRequest { ClientId = clientId };
            return await Client.Execute<GetCreditsRequest, GetCreditsResponse>(request);
        }

        public async Task<GetInvoiceResponse> GetInvoices(GetInvoiceRequest request = null)
        {
            request = request ?? new GetInvoiceRequest();
            return await Client.Execute<GetInvoiceRequest, GetInvoiceResponse>(request);
        }


        public async Task<GetQuotesResponse> GetQuotes(GetQuotesRequest request = null)
        {
            request = request ?? new GetQuotesRequest();
            return await Client.Execute<GetQuotesRequest, GetQuotesResponse>(request);
        }

        public async Task<GetPayMethodsResponse> GetPayMethods(GetPayMethodsRequest request)
        {
            return await Client.Execute<GetPayMethodsRequest, GetPayMethodsResponse>(request);
        }

        public async Task<GetInvoiceResponse> GetInvoice(int invoiceId)
        {
            var request = new GetInvoiceRequest { InvoiceId = invoiceId };
            return await Client.Execute<GetInvoiceRequest, GetInvoiceResponse>(request);
        }
    }
}