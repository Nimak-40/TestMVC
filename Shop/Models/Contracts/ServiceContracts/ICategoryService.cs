using Shop.Models.Entities;

namespace Shop.Models.Contracts.ServiceContracts
{
    public interface ICategoryService
    {
        public List<Category> GetAllCategories();
        public void SetCategory(string categoryName,string categoryDescription);
    }
}
