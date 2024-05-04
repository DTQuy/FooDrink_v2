using FoodDrink.Service.Interface;
using FooDrink.Repository.Interface;

namespace FoodDrink.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository? _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

    }
}
