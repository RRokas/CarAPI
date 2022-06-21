using System;

namespace CarAPI.Models
{
    public class User
    {
        public Guid Id { get; init; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
