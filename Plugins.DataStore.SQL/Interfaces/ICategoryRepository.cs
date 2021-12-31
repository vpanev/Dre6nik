using System;
using System.Collections.Generic;
using CoreBusiness;

namespace Plugins.DataStore.SQL
{
    public interface ICategoryRepository : IDisposable
    {
        IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        Category GetCategoryById(int categoryId);
        void DeleteCategory(int categoryId);
    }

}
