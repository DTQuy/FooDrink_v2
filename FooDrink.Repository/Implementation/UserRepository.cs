using FooDrink.database;
using FooDrink.Repository.Interface;

namespace FooDrink.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
