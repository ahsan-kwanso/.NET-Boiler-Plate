public interface IUserService
{
    Task<User> GetUserAsync(int id);
} 