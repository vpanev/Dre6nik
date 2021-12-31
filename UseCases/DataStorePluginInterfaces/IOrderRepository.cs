using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        Order GetOrderById(int orderId);
        void DeleteOrder(int orderId);
    }
}
