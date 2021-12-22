using System.Collections.Generic;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category{ CategoryId = 1, Name = "T-Shirts", Description = "Short sleeved shirts"},
                new Category{ CategoryId = 2, Name = "Polo", Description = "Long sleeved shirts with long neck"},
                new Category{ CategoryId = 3, Name = "Jackets", Description = "Clothes made for outside when it is cold"},
            };
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}
