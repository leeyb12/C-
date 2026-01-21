// 분해 시 기존 변수에 값을 할당

static (int x, int y, string text) MethodReturningTuple() => (1, 2, "t");

static void Main()
{
    // 세 개의 변수를 각기 선언, 초기화 후 사용
    int a = 20;
    int b = 30;
    string name = "before";
    Console.WriteLine($"a: {a}, b: {b}, name: {name}");

    (a, b, name) = MethodReturningTuple();  // 분해를 통해 세 개의 변수가 값을 할당

    Console.WriteLine($"a: {a}, b: {b}, name: {name}");  // 새로운 값을 출력
}