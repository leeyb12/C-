// 비동기 메서드 내에서 매개변수의 유효성 검사 실패

static async Task MainAsync()
{
    Task<int> task = ComputeLengthAsync(null);  // 의도적으로 잘못된 인수를 전달
    Console.WriteLine("Fetched the task");
    int length = await.task;  // 결과를 대기
    Console.WriteLine("Length: {0}", length);
}

static async Task<int> ComputeLengthAsync(string text)
{
    if (text == null)
    {
        throw new ArgumentNullException("text");  // 가능한 한 빨리 예외를 발생시킴
    }
    await Task.Delay(500);  // 비동기 작업을 시뮬레이션
    return text.Length;
}