using dotnet.Models;

namespace dotnet.Services;

public class OrderProcessingService : IOrderProcessingService
{
    private readonly IEmailSenderServices _emailSender;

    public OrderProcessingService()
    {
        _emailSender = new EmailSenderService();
    }

    public bool ProcessOrder(Order order)
    {
        if (HandleOrder(order))
        {
            _emailSender.SendEmail("customer@gmail.com", "Order has been processed", null);
        }
        else
        {
            _emailSender.SendEmail("customer@gmail.com", "Order was not processed", null);
        }
        return true;
    }

    private bool HandleOrder(Order order)
    {
        return true;
    }
}
