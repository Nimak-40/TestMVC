using Shop.Models.Contracts.RepositoriyContracts;
using Shop.Models.Contracts.ServiceContracts;
using Shop.Models.Entities;
using Shop.Models.Repositories;

namespace Shop.Models.Services
{
    public class UserService:IUserServices
    {
        private readonly IUserRepo _repository;

        public UserService()
        {
            _repository = new UserRepo();
        }

        public bool RegisterUser(string username, string email, string password)
        {
            if (_repository.GetUserByEmail(email) != null)
                return false; // کاربر از قبل وجود دارد

            var user = new User
            {
                UserName = username,
                Email = email,
                Password = password
            };

            _repository.AddUser(user);
            return true;
        }

        public bool LoginUser(string email, string password)
        {
            var user = _repository.GetUserByEmail(email);
            return user != null && user.Password == password;
        }
    }
}
