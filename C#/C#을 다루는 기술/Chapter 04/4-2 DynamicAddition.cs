// 동적 타입의 값에 덧셈 연산을 수행

static void Add(dynamic d)
{
    Console.WriteLine(d + d);  // 런타임 시 변수의 타입을 고려하여 덧셈을 수행
}

// 각기 다른 타입으로 메서드 호출
Add("text");
Add(10);
Add(TimeSpan.FromMinutes(45));