namespace Banking.Api.Models;

public class TransferRequest
{
    public Guid SourceAccountId { get; set; }

    public Guid DestinationAccountId { get; set; }

    public decimal Amount { get; set; }

    public string Currency { get; set; } = "CRC";

    public string Description { get; set; } = string.Empty;
}