using System;
using System.Collections.Generic;
using CoreBusiness;

namespace Plugins.DataStore.SQL
{
    public interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProductById(int productId);
        void DeleteProduct(int productId);
    }
}
