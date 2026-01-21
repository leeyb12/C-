// 단순 재시도 루프

static T Retry<T>(Func<T> operation, int attempts)
{
    while (true)
    {
        try
        {
            attempts--;
            return operation();
        }
        catch (Exception e) when (attempts > 0)
        {
            Console.WriteLine($"Failed: {e}");
            Console.WriteLine($"Attempts left: {attempts}");
            Thread.Sleep(5000);
        }
    }
}