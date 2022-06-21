using CarAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CarAPI.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly MssqlDbContext _context;

        public UserRepository(MssqlDbContext context)
        {
            _context = context;
        }

        public void AddUser(User userToAdd) 
        {
            _context.Add(userToAdd);
            _context.SaveChanges();
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.Where(x => x.Username == username).First();
        }
    }
}
