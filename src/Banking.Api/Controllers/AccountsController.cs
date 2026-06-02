using Banking.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Api.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/accounts")]
public class AccountsController : ControllerBase
{
    [HttpGet("{id}/balance")]
    public IActionResult Balance(Guid id)
    {
        return Ok(
            new AccountBalance
            {
                AccountId = id,
                Balance = 250000,
                Currency = "CRC"
            });
    }

    [HttpGet("{id}/transactions")]
    public IActionResult Transactions(Guid id)
    {
        return Ok(
            new List<Transaction>
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Amount = 50000,
                    Date = DateTime.UtcNow,
                    Description = "Pago servicios"
                }
            });
    }
}