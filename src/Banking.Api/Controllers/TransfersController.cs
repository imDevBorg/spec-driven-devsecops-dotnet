using Banking.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Api.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/transfers")]
public class TransfersController : ControllerBase
{
    [HttpPost]
    public IActionResult Transfer(
        TransferRequest request)
    {
        return Ok(new
        {
            transactionId = Guid.NewGuid(),
            status = "APPROVED",
            amount = request.Amount
        });
    }
}