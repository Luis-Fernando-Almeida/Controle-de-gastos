using ControleDeGastos.Models;

namespace ControleDeGastos.Repository
{
    public interface IUserRepository
    {
        void Add(User user);

        List<User> Get();
    }
}
