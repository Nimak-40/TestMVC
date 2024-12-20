using Microsoft.EntityFrameworkCore;
using Shop.Models.Contracts.RepositoriyContracts;
using Shop.Models.Entities;
using Shop.Models.Infrustructure;

namespace Shop.Models.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;

        public ProductRepo()
        {
            _context = new AppDbContext();
        }
        public List<Product> GetAllProcuts()
        {
            return _context.Products.AsNoTracking().Include(c=>c.Category).ToList();

        }
        public Product GetProductById(int id) =>_context.Products.FirstOrDefault(p=>p.Id==id);
    }


}
