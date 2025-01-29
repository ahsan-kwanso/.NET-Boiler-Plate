using System.Threading.Tasks;
using MyAspNetApp.Models;
using MyAspNetApp.Models.DTOs;

namespace MyAspNetApp.Services
{
    public interface IAuthService
    {
        Task<User> SignUpAsync(SignUpDto signUpDto);
        Task<User> SignInAsync(SignInDto signInDto);
    }
}