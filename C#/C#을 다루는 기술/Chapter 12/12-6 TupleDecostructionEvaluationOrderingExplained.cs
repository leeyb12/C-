// 분해 시 수행되는 평가 순서를 보여주기 위한 코드

StringBuilder builder = new StringBuilder("12345");
StringBuilder original = builder;

StringBuilder targetForLength = builder;  // 할당 대상 평가

// 튜플 리터럴 평가
(StringBuilder, int) tuple =
    (new StringBuilder("67890"), 3);

// 할당 대상으로 할당 수행
builder = tuple.Item1;
targetForLength.Length = tuple.Item2;

Console.WriteLine(original);
Console.WriteLine(builder);