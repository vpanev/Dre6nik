using System.Collections.Generic;
using CoreBusiness;

namespace UseCases
{
    public interface IViewCategoriesUseCase
    {
        public IEnumerable<Category> Execute();
    }
}
