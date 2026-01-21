// try 블록 내에 await 배치

static async Task AwaitInTryFinally(TimeSpan delay)
{
    Console.WriteLine("Before try block");
    try
    {
        Console.WriteLine("Before await");
        await Task.Delay(delay);
        Console.WriteLine("After await");
    }
    finally
    {
        Console.WriteLine("In finally block");
    }
    Console.WriteLine("After finally block");
}