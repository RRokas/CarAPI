using CarAPI.Models;

namespace CarAPI.Services
{
    public interface IUserRepository
    {
        public void AddUser(User userToAdd);
        public User GetUserByUsername(string username);
    }
}
