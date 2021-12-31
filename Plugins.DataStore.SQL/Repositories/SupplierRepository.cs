using System;
using System.Collections.Generic;
using System.Linq;
using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class SupplierRepository : ISupplierRepository, IDisposable
    {
        private Dre6nikAppContext context;

        public SupplierRepository(Dre6nikAppContext context)
        {
            this.context = context;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return context.Suppliers.ToList();
        }

        public void AddSupplier(Supplier supplier)
        {
            context.Suppliers.Add(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            context.Entry(supplier).State = EntityState.Modified;
        }

        public Supplier GetSupplierById(int supplierId)
        {
            return context.Suppliers.Find(supplierId);
        }

        public void DeleteSupplier(int supplierId)
        {
            Supplier supplier = context.Suppliers.Find(supplierId);
            context.Suppliers.Remove(supplier);
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
