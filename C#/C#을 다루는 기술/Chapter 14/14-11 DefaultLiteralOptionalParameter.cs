// 메서드의 인수로 default 리터럴을 사용

static void PrintValue(int value = 10)  // 매개변수의 기본값은 10
{
    Console.WriteLine(value);
}

static void Main()
{
    PrintValue(default);  // 메서드의 인수는 int의 기본값
}