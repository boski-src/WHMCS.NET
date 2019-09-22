using System.Threading.Tasks;
using WHMCS.NET.Modules.Order.AcceptOrder;
using WHMCS.NET.Modules.Order.AddOrder;
using WHMCS.NET.Modules.Order.CancelOrder;
using WHMCS.NET.Modules.Order.DeleteOrder;
using WHMCS.NET.Modules.Order.FraudOrder;
using WHMCS.NET.Modules.Order.GetOrders;
using WHMCS.NET.Modules.Order.GetOrderStatuses;
using WHMCS.NET.Modules.Order.GetProducts;
using WHMCS.NET.Modules.Order.GetPromotions;
using WHMCS.NET.Modules.Order.OrderFraudCheck;
using WHMCS.NET.Modules.Order.PendingOrder;

namespace WHMCS.NET.Modules.Order
{
    public class OrderModule : Module
    {
        public async Task<AcceptOrderResponse> Accept(AcceptOrderRequest request)
        {
            return await Client.Execute<AcceptOrderRequest, AcceptOrderResponse>(request);
        }

        public async Task<AddOrderResponse> Add(AddOrderRequest request)
        {
            return await Client.Execute<AddOrderRequest, AddOrderResponse>(request);
        }

        public async Task<CancelOrderResponse> Cancel(CancelOrderRequest request)
        {
            return await Client.Execute<CancelOrderRequest, CancelOrderResponse>(request);
        }

        public async Task<DeleteOrderResponse> Delete(int orderId)
        {
            var request = new DeleteOrderRequest { OrderId = orderId };
            return await Client.Execute<DeleteOrderRequest, DeleteOrderResponse>(request);
        }

        public async Task<FraudOrderResponse> Fraud(FraudOrderRequest request)
        {
            return await Client.Execute<FraudOrderRequest, FraudOrderResponse>(request);
        }

        public async Task<GetOrdersResponse> Browse(GetOrdersRequest request = null)
        {
            request = request ?? new GetOrdersRequest();
            return await Client.Execute<GetOrdersRequest, GetOrdersResponse>(request);
        }

        public async Task<GetOrderStatusesResponse> BrowseStatuses(GetOrderStatusesRequest request = null)
        {
            request = request ?? new GetOrderStatusesRequest();
            return await Client.Execute<GetOrderStatusesRequest, GetOrderStatusesResponse>(request);
        }

        public async Task<GetProductsResponse> BrowseProducts(GetProductsRequest request = null)
        {
            request = request ?? new GetProductsRequest();
            return await Client.Execute<GetProductsRequest, GetProductsResponse>(request);
        }

        public async Task<GetPromotionsResponse> BrowsePromotions(GetPromotionsRequest request = null)
        {
            request = request ?? new GetPromotionsRequest();
            return await Client.Execute<GetPromotionsRequest, GetPromotionsResponse>(request);
        }

        public async Task<OrderFraudCheckResponse> FraudCheck(OrderFraudCheckRequest request)
        {
            return await Client.Execute<OrderFraudCheckRequest, OrderFraudCheckResponse>(request);
        }

        public async Task<PendingOrderResponse> Pending(PendingOrderRequest request)
        {
            return await Client.Execute<PendingOrderRequest, PendingOrderResponse>(request);
        }
    }
}