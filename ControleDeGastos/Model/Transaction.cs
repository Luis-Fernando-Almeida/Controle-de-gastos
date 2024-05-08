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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private long? Id { get; set; }
        private decimal Amount { get; set; }

        private Type Type { get; set; }

        private DateTime DateTime { get; set; }


        public Transaction(long id, decimal amount, Type type, DateTime dateTime)
        {
            Id = id;
            Amount = amount;
            Type = type;
            DateTime = dateTime;
        }

    
    }
}
