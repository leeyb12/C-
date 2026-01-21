// 대기 표현식 사이에 루프 배치

static async Task PrintAndWaitWithSimpleLoop(TimeSpan delay)
{
    Console.WriteLine("Before first delay");
    await Task.Delay(delay);
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Between delays");
    }
    await Task.Delay(delay);
    Console.WriteLine("After second delay");
}