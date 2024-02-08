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

    public User? AddNew(User newUserData)
    {
        var existingUser = _appDbContext.Users.FirstOrDefault(user =>
            user.Email.Equals(newUserData.Email) || user.Login.Equals(newUserData.Login));
        if (existingUser == null)
        {
            var newUser = _appDbContext.Users.Add(newUserData).Entity;
            _appDbContext.SaveChanges();
            return newUser;
        }
        return null;
    }
}