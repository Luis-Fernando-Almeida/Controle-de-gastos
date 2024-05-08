using ControleDeGastos.Infra;
using ControleDeGastos.Models;

namespace ControleDeGastos.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public List<User> Get()
        {
            return _context.Users.ToList();
        }
    }
}
