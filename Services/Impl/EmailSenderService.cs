namespace dotnet.Services;

public class EmailSenderService : IEmailSenderServices
{
    private readonly IChatGPTService _chatGPTService;
    public EmailSenderService()
    {
        _chatGPTService = new ChatGPTService();
    }
    public bool SendEmail (string to, string subject, string? body = null)
    {
        var emailBody = body;
        if (body is null)
        {
            emailBody = _chatGPTService.GetSuggestion(subject);
        }
        return true;
    }
}