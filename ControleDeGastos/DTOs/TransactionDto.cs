namespace ControleDeGastos.DTOs
{
    public record TransactionDto
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public required Type Type { get; init; }
    }
}
