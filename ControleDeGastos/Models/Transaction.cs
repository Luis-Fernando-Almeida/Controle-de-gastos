using System.Numerics;

namespace ControleDeGastos.Models
{
    public class Transaction
    {
        private long Id { get; set; }
        private BigInteger amount { get; set; }

        private DateTime DateTime { get; set; }

        public Transaction() { }
        public Transaction(long id, BigInteger amount) { Id = id;}
    }
}
