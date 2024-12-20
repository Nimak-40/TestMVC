using Shop.Models.Contracts.RepositoriyContracts;
using Shop.Models.Contracts.ServiceContracts;
using Shop.Models.Entities;
using Shop.Models.Infrustructure;
using Shop.Models.Repositories;

namespace Shop.Models.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _CategoryRepo;

        public CategoryService()
        {
            _CategoryRepo = new CategoryRepo();
        }
        public List<Category> GetAllCategories()
        {

            var resualt = _CategoryRepo.GetAllCategories();
            return resualt;
        }
        public void SetCategory(string categoryName, string description)
        {

            var category = new Category
            {
                Name = categoryName,
                Description = description
            };
            _CategoryRepo.SetCategory(category);

        }
    }
}
