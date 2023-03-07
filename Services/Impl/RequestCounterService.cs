namespace dotnet.Services;

public class RequestCounterService : ICounterService
{
    private int _counter = 0;

    public int CurrentValue
    {
        get { return _counter; }
    }

    public void Increase()
    {
        Interlocked.Increment(ref _counter);
    }

    public void Decrease()
    {
        Interlocked.Decrement(ref _counter);
    }
}