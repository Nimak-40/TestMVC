using Microsoft.EntityFrameworkCore;
using Shop.Models.Contracts;
using Shop.Models.Contracts.RepositoriyContracts;
using Shop.Models.Entities;
using Shop.Models.Infrustructure;
using System;

namespace Shop.Models.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext _context;

        public CategoryRepo()
        {
            _context = new AppDbContext();
        }
        public List<Category> GetAllCategories()
        {
            return _context.Categorys.AsNoTracking().ToList();
                
        }
    }

}
