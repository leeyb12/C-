// 메서드 호출 후 반환값을 세 개의 변수로 분해

static (int x, int y, string text) MethodReturningTuple() => (1, 2, "t");

static void Main()
{
    (int a, int b, string name) = MethodReturningTuple();
    Console.WriteLine($"a: {a}, b: {b}, name: {name}");
}