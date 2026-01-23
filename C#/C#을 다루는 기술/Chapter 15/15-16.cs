// IAsyncDisposal을 구현하고 using await를 사용

class AsyncResource : IAsyncDisposable
{
    public async Task DisposeAsync()
    {
        Console.WriteLine("Disposing asynchronously...");
        await Task.Delay(2000);
        Console.WriteLine("...done");
    }

    public async Task PerformWorkAsync()
    {
        Console.WriteLine("Performing work asynchronously");
        await Task.Delay(2000);
        Console.WriteLine("...done");
    }
}

async static Task Main()
{
    using await (var resource = new AsyncResource())
    {
        await resource.PerformWorkAsync();
    }
    Console.WriteLine("After the using await statement");
}