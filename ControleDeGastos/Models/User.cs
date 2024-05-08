using System.Numerics;

namespace ControleDeGastos.Models
{
    public class User
    {
        private long Id { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private decimal balance { get; set; }
 

        public User(long id, string name, string email, string password, decimal balance)
        {
            Id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.balance = balance;
        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
