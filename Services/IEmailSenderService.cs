namespace dotnet.Services;

public interface IEmailSenderServices
{
    bool SendEmail (string to, string subject, string? body);
    
}