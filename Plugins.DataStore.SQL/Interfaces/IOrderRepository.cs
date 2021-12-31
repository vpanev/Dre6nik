using System;
using System.Collections.Generic;
using CoreBusiness;

namespace Plugins.DataStore.SQL
{
    public interface IOrderRepository : IDisposable
    {
        IEnumerable<Order> GetOrders();
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        Order GetOrderById(int orderId);
        void DeleteOrder(int orderId);
    }
}
