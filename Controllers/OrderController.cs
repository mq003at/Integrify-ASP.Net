namespace dotnet.Controllers;

using Microsoft.AspNetCore.Mvc;
using dotnet.Models;
using dotnet.Services;

[ApiController]
[Route("[controller]s")]
public class OrderController : ApiControllerBase
{
    private readonly IOrderProcessingService _service;
    private readonly ILogger<OrderController> _logger;
    private readonly ICounterService _counterService;

    public OrderController(IOrderProcessingService service, ILogger<OrderController> logger, ICounterService counterService)
    {
        _service = service;
        _logger = logger;
        _counterService = counterService;
        _counterService.Increase();
    }
    [HttpPost]
    public IActionResult MakeOrder (Order order)
    {
        if (!_service.ProcessOrder(order)) 
        {
            _logger.LogError($"Fail to process order: {order.CustomerID}");
        }
        return Ok(new {Message = $"Order {order.CustomerID} has been processed."});
    }
}