// 완료된 작업과 완료되지 않은 작업 대기

static void Main()
{
    Task task = DemoCompletedAsync();  // 비동기 메서드 호출
    Console.WriteLine("Method returned");
    task.Wait();  // 작업이 완료될 때까지 중단
    Console.WriteLine("Task completed");
}

static async Task DemoCompletedAsync()
{
    Console.WriteLine("Before first await");
    await Task.FromResult(10);  // 완료된 작업을 대기
    Console.WriteLine("Between awaits");
    await.Task.Delay(1000);
    Console.WriteLine("After second await");
}