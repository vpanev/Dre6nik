using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        Supplier GetSupplierById(int supplierId);
        void DeleteSupplier(int supplierId);
    }
}
