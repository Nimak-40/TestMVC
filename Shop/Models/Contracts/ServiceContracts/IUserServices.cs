using Shop.Models.Entities;

namespace Shop.Models.Contracts.ServiceContracts
{
    public interface IUserServices
    {
        public bool RegisterUser(string username, string email, string password);
        public bool LoginUser(string email, string password);
    }
}
