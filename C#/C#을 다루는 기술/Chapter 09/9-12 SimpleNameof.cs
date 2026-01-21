// 클래스, 메서드, 필드, 매개변수의 이름을 출력

using System;

class SimpleNameof
{
    private string field;

    static void Main(string[] args)
    {
        Console.WriteLine(nameof(SimpleNameof));
        Console.WriteLine(nameof(Main));
        Console.WriteLine(nameof(args));
        Console.WriteLine(nameof(field));
    }
}