// 동적 메서드의 오버로딩 해석

static void SampleMethod(int value)
{
    Console.WriteLine("Method with int parameter");
}

static void SampleMethod(decimal value)
{
    Console.WriteLine("Method with decimal parameter");
}

static void SampleMethod(object value)
{
    Console.WriteLine("Method with object parameter");
}
static void CallMethod(dynamic d)
{
    SampleMethod(d);  // SampleMethod를 동적으로 수행
}

// 서로 다른 타입을 이용하여 SampleMethod를 간접 호출
CallMethod(10);
CallMethod(10.5m);
CallMethod(10L);
CallMethod("text");