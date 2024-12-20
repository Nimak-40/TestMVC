using Microsoft.EntityFrameworkCore;
using Shop.Models.Contracts.RepositoriyContracts;
using Shop.Models.Contracts.ServiceContracts;
using Shop.Models.Entities;
using Shop.Models.Repositories;

namespace Shop.Models.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService()
        {
            _productRepo = new ProductRepo();
        }
        public List<Product> GetAllProcuts()
        {
            return _productRepo.GetAllProcuts();

        }
        public Product GetProductById(int id)
        {
            return _productRepo.GetProductById(id);
        }
    }
}
