using System.Numerics;

namespace ControleDeGastos.Models
{
    public class User
    {
        private long Id { get; set; }
        private string name { get; set; }
        private string email { get; set; }

        private string password { get; set; }
        private BigInteger amount { get; set; }

        public User(long id, string name, string email, string password, BigInteger amount)
        {
            Id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.amount = amount;
        }
    }
}
