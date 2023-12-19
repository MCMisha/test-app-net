using WebApplication4.Contexts;
using WebApplication4.Models;

namespace WebApplication4.Repositories;

public class UserRepository
{
    private readonly AppDbContext _appDbContext;

    public UserRepository(IConfiguration configuration)
    {
        _appDbContext = new AppDbContext(configuration);
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _appDbContext.Users;
    }

    public User? GetById(uint id)
    {
        return _appDbContext.Users.FirstOrDefault(user => user.Id == id);
    }
}