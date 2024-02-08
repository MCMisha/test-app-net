using WebApplication4.Models;
using WebApplication4.Repositories;

namespace WebApplication4.Services;

public class UserService
{
    private readonly UserRepository _userRepository;

    public UserService(IConfiguration configuration)
    {
        _userRepository = new UserRepository(configuration);
    }

    public IEnumerable<User> GetUsers()
    {
        return _userRepository.GetAllUsers();
    }

    public User? GetUserById(uint id)
    {
        return _userRepository.GetById(id);
    }

    public User? AddNewUser(User newUserData)
    {
        return _userRepository.AddNew(newUserData);
    }
}