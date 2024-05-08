namespace ControleDeGastos.DTOs
{
    public class UserDto
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public decimal balance { get; set; }
    }
}
