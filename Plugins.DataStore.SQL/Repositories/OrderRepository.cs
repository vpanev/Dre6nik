using System;
using System.Collections.Generic;
using System.Linq;
using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class OrderRepository : IOrderRepository, IDisposable
    {
        private Dre6nikAppContext context;

        public OrderRepository(Dre6nikAppContext context)
        {
            this.context = context;
        }

        public IEnumerable<Order> GetOrders()
        {
            return context.Orders.ToList();
        }

        public void AddOrder(Order order)
        {
            context.Orders.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            context.Entry(order).State = EntityState.Modified;
        }

        public Order GetOrderById(int orderId)
        {
            return context.Orders.Find(orderId);
        }

        public void DeleteOrder(int orderId)
        {
            Order order = context.Orders.Find(orderId);
            context.Orders.Remove(order);
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
