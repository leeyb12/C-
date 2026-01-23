// null 허용 연산자를 사용

static void PrintLength(string? text)  // 입력은 null이 될 수 있음
{
    if (!string.IsNullOrEmpty(text))  // IsNullOrEmpty가 false를 반환하면 nulll이 아님
    {
        Console.WriteLine($"{text}: {text!.Length}");  // null 허용 연산자를 사용하여 컴파일러에게 null이 될 수 없음을 알림
    }
    else
    {
        Console.WriteLine("Empty or null");
    }
}