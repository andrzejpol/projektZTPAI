using backend.Entities;
using backend.Models;
using Microsoft.AspNetCore.Identity;
using System.Xml;

namespace backend.Services
{
    public interface IAuthService
    {
        void RegisterUser(RegisterUserDto dto);
    }
    public class AuthService : IAuthService
    {
        private readonly PreschoolDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;
        public AuthService(PreschoolDbContext dbContext, IPasswordHasher<User> passwordHasher) 
        {
            _context = dbContext;
            _passwordHasher = passwordHasher;
        }
        public void RegisterUser(RegisterUserDto dto) 
        {
            var newUser = new User()
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                RoleId = dto.RoleId
            };

            var hashedPassword = _passwordHasher.HashPassword(newUser, dto.Password);
            newUser.PasswordHash = hashedPassword;

            _context.Users.Add(newUser);
            _context.SaveChanges();
        }
    }
}
