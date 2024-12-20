using Microsoft.EntityFrameworkCore;
using Shop.Models.Entities;

namespace Shop.Models.Contracts.RepositoriyContracts
{
    public interface IProductRepo
    {
        public List<Product> GetAllProcuts();
        public Product GetProductById(int id);
    }
}
