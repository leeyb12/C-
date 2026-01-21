// 컬렉션 내의 요소 중 일부만을 복사하는 예

public static List<T> CopyAtMost<T>(  // 타입 매개변수 T를 이용하여 메서드를 선언하고,
    List<T> input, int maxElements)  // 메서드의 일반 매개변수와 반환 타입으로 활용
{
    int actualCount = Math.Min(input.Countm maxElements);
    List<T> ret = new List<T>(actualCount);  // 메서드 본문에서도 타입 매개변수를 사용
    for (int i = 0; i < actualCount; i++)
    {
        ret.Add(input[i]);
    }
    return ret;
}

static void Main()
{
    List<int> numbers = new List<int>();
    numbers.Add(5);
    numbers.Add(10);
    numbers.Add(20);

    List<int> firstTwo = CopyAtMost<int>(numbers, 2);  // 타입 매개변수로 int를 지정하여 메서드를 호출
    Console.WriteLine(firstTwo.Count);
}