using Microsoft.EntityFrameworkCore;
using Shop.Models.Contracts.RepositoriyContracts;
using Shop.Models.Entities;
using Shop.Models.Infrustructure;

namespace Shop.Models.Repositories
{
    public class UserRepo: IUserRepo
    {
        private readonly AppDbContext _context;

        public UserRepo()
        {
            _context = new AppDbContext();
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.AsNoTracking().FirstOrDefault(u => u.Email == email);
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
