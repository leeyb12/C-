// 제네릭 타입의 정적 필드 처리

class GenericCounter<T>
{
    private static int value;  // 닫혀 있고 구성된 타입별로 하나씩 존재

    static GenericCounter()
    {
        Console.WriteLine("Initializing counter for {0}", typeof(T));
    }

    public static void Increment()
    {
        value++;
    }

    public static void Display()
    {
        Console.WriteLine("Counter for {0}: {1}", typeof(T), value);
    }
}

class GenericCounterDemo
{
    static void Main()
    {
        GenericCounter<String>.Increment();  // GenericCounter<string> 초기화 수행
        GenericCounter<string>.Increment();
        GenericCounter<string>.Display();
        GenericCounter<int>.Display();  // GenericCounter<int> 초기화 수행
        GenericCounter<int>.Increment();
        GenericCounter<int>.Display();
    }
}