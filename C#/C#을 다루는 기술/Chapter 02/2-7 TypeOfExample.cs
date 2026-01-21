// typeof 연산자의 결과를 출력하는 예

static void PrintType<T>()
{
    Console.WriteLine("typeof(T) = {0}", typeof(T));  // typeof(T)와 typeof(List<T>)의 결과를 출력
    Console.WriteLine("typeof(List<T>) = {0}", typeof(List<T>));
}

static void Main()
{
    PrintType<string>();  // 타입 인수로 string을 사용하여 메서드를 호출
    PrintType<int>();  // 타입 인수로 int를 사용하여 메서드를 호출
}