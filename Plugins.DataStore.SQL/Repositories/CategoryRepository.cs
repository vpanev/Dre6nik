using System;
using System.Collections.Generic;
using System.Linq;
using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class CategoryRepository : ICategoryRepository, IDisposable
    {
        private Dre6nikAppContext context;

        public CategoryRepository(Dre6nikAppContext context)
        {
            this.context = context;
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            context.Entry(category).State = EntityState.Modified;
        }

        public Category GetCategoryById(int categoryId)
        {
            return context.Categories.Find(categoryId);
        }

        public void DeleteCategory(int categoryId)
        {
            Category category = context.Categories.Find(categoryId);
            context.Categories.Remove(category);
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
