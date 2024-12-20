using Microsoft.EntityFrameworkCore;
using Shop.Models.Entities;

namespace Shop.Models.Contracts.ServiceContracts
{
    public interface IProductService
    {
        public List<Product> GetAllProcuts();
        public Product GetProductById(int id);
    }
}
