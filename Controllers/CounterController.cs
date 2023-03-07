namespace dotnet.Controllers;

using Microsoft.AspNetCore.Mvc;
using dotnet.Models;
using dotnet.Services;

[ApiController]
[Route("[controller]s")]
public class CounterController : ApiControllerBase
{
    private readonly ILogger<OrderController> _logger;
    private readonly ICounterService _counterService;

    public CounterController(ILogger<OrderController> logger, ICounterService counterService)
    {
        _logger = logger;
        _counterService = counterService;
    }
    [HttpGet]
    public IActionResult GetCounter()
    {
        return Ok(new { CounterValue = _counterService.CurrentValue} );
    }
}