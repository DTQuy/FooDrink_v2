using FoodDrink.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FooDrink.API.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
    }
}
