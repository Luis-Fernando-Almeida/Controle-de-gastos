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
        public long id { get; set; }
        public decimal Amount { get; set; }
        public Type Type { get; set; }
        public DateTime DateTime { get; set; }

    
    }
}
