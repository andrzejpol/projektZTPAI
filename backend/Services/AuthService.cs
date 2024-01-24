using backend.Entities;
using backend.Models;
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
        public AuthService(PreschoolDbContext dbContext) 
        {
            _context = dbContext;
        }
        public void RegisterUser(RegisterUserDto dto) 
        {
            var newUser = new User()
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PasswordHash = dto.Password,
                RoleId = dto.RoleId
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();
        }
    }
}
