using Microsoft.EntityFrameworkCore;
using MyAspNetApp.Models;
using MyAspNetApp.Models.DTOs;

namespace MyAspNetApp.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;

        public AuthService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> SignUpAsync(SignUpDto signUpDto)
        {
            // Check if user already exists
            if (await _context.Users.AnyAsync(u => u.Email == signUpDto.Email))
            {
                throw new Exception("User with this email already exists");
            }

            var user = new User
            {
                Email = signUpDto.Email,
                Password = signUpDto.Password, // Note: We'll add password hashing later
                FirstName = signUpDto.FirstName,
                LastName = signUpDto.LastName
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> SignInAsync(SignInDto signInDto)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == signInDto.Email);

            if (user == null || user.Password != signInDto.Password) // We'll improve this with proper password verification later
            {
                throw new Exception("Invalid email or password");
            }

            return user;
        }
    } 
}