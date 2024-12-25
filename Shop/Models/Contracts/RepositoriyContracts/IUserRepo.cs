using Microsoft.EntityFrameworkCore;
using Shop.Models.Entities;

namespace Shop.Models.Contracts.RepositoriyContracts
{
    public interface IUserRepo
    {
        public User GetUserByEmail(string email);
        public void AddUser(User user);
    }
}
