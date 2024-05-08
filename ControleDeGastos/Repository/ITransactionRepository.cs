using ControleDeGastos.Models;

namespace ControleDeGastos.Repository
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);

        void Update(Transaction transaction);

        void Delete(Transaction transaction);

        List<Transaction> Get();
    }
}
