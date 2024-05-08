namespace ControleDeGastos.DTOs
{
    public record UserDto
    {
        public long Id { get; set; }
        public required string Name { get; init; }
        public required string Email { get;init; }
        public decimal Balance { get; set; }
    }
}
