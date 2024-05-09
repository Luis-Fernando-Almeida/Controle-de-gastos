using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace ControleDeGastos.Models
{
    public enum Type
    {
        Credit, Debit, Pix
    }
    public class Transaction
    {
        private decimal Amount { get; set; }
        private Type Type { get; set; }
        private DateTime DateTime { get; set; }

        public Transaction(decimal amount, Type type, DateTime dateTime)
        {
            Amount = amount;
            Type = type;
            DateTime = dateTime;
        }

    
    }
}
