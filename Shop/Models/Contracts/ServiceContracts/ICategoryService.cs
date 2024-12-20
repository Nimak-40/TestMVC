using Shop.Models.Entities;

namespace Shop.Models.Contracts.ServiceContracts
{
    public interface ICategoryService
    {
        public List<Category> GetAllCategories();
    }
}
