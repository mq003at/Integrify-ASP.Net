namespace dotnet.Services;

using dotnet.Models;

public interface IOrderProcessingService
{
    bool ProcessOrder(Order order);
}