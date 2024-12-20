using Shop.Models.Entities;
using Shop.Models.Infrustructure;

namespace Shop.Models.Contracts.RepositoriyContracts
{
    public interface ICategoryRepo
    {
        public List<Category> GetAllCategories();

    }
}
