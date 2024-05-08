using ControleDeGastos.Infra;
using ControleDeGastos.Models;

namespace ControleDeGastos.Repository
{
    public class TransactionRepository : ITransactionRepository
    {

        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public void Add(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public void Update(Transaction transaction)
        {
            _context.Transactions.Update(transaction);
            _context.SaveChanges();
        }

        public void Delete(Transaction transaction)
        {
            _context.Transactions.Remove(transaction);
            _context.SaveChanges();
        }

        public List<Transaction> Get()
        {
            return _context.Transactions.ToList();
        }
    }
}
