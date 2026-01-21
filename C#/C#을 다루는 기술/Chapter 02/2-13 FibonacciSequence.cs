// 피보나치 시퀸스 출력

static IEnumerable<int> Fibonacci()
{
    int current = 0;
    int next = 1;

    while (true)  // 무한 루프?값을 요청할 때만 무한히 반복
    {
        yield return current;  // 현재 피보나치 값을 반환
        int oldCurrent = current;
        current = next;
        next = next + oldCurrent;
    }
}

static void Main()
{
    foreach (var value in Fibonacci())  // 피보나치 값을 얻기 위해 메서드 호출
    {
        Console.WriteLine(value);  // 현재 값 출력
        if (value > 1000)  // 중단 조건 확인
        {
            break;
        }
    }
}