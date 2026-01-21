// 간단한 이터레이터 메서드, 역컴파일(decompile)의 결과를 보여주기 위한 예

public static IEnumerable<int> GenerateIntegers(int count)
{
    try
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Yielding {0}", i);
            yield return i;
            int doubled = 1 * 2;
            Console.WriteLine("Yielding {0}", doubled);
            yield return doubled;
        }
    }
    finally
    {
        Console.WriteLine("In finally block");
    }
}