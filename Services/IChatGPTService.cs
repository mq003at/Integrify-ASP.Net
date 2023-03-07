namespace dotnet.Services;

public interface IChatGPTService
{
    string GetSuggestion(string message);
}