namespace Banking.Api.Models;

public class AccountBalance
{
    public Guid AccountId { get; set; }

    public decimal Balance { get; set; }

    public string Currency { get; set; } = "CRC";
}