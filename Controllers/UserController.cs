using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;
using WebApplication4.Contexts;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly UserService _userService;
        
        public UserController(ILogger<UserController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _userService = new UserService(configuration);
        }
        
        
        [HttpGet("all")]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(uint id)
        {
            User? user = _userService.GetUserById(id);
            return user != null ? Ok(user) : NotFound($"Użytkownik o id {id} nie został znaleziony");
        }
        
        
    }
}
