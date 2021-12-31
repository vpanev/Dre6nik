using System;
using System.Collections.Generic;
using CoreBusiness;

namespace Plugins.DataStore.SQL
{
    public interface ISupplierRepository : IDisposable
    {
        IEnumerable<Supplier> GetSuppliers();
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        Supplier GetSupplierById(int supplierId);
        void DeleteSupplier(int supplierId);
    }
}
