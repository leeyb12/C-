// 루프 내에 대기 표현식이 있는 예

static async Task AwaitInLoop(TimeSpan delay)
{
    Console.WriteLine("Before loop");
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Before await in loop");
        await Task.Delay(delay);
        Console.WriteLine("After await in loop");
    }
    Console.WriteLine("After loop delay");
}