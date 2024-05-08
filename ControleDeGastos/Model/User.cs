using System.Numerics;

namespace ControleDeGastos.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
 
        public User(long id, string name, string email, string password, decimal balance)
        {
            Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.Balance = balance;
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
