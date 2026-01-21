// 비동기 메서드 내에서 unsafe 코드를 사용

static async Task DelayWithResultOfUnsafeCode(string text)
{
    int total = 0;
    unsafe  // 비동기 메서드 내에 unsafe 컨텍스트를 두는 것은 문제가 되지 않음
    {
        fixed (char* textPointer = text)
        {
            char* p = textPointer;
            while (*p != 0)
            {
                total += *p;
                p++;
            }
        }
    }
    Console.WriteLine("Delaying for " + total + "ms");
    await Task.Delay(total);  // 하지만 unsafe 컨텍스트 내에 await 표현식을 둘 수는 없음
    Console.WriteLine("Delay complete");
}