namespace dotnet.Services;

public interface ICounterService
{
    void Increase();
    void Decrease();
    int CurrentValue {get; }
}