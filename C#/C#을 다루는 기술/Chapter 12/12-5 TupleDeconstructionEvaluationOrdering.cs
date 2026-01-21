// 평가 순서가 영향을 미치는 분해 과정

StringBuilder builder = new StringBuilder("12345");
StringBuilder original = builder;  // 분석을 기존 빌더 객체의 참조를 복사

// 분해 시 할당이 수행됨
(builder, builder.Length) =
    (new StringBuilder("67890"), 3);

// 이전 빌더와 새 빌더의 내용을 출력
Console.WriteLine(original);
Console.WriteLine(builder);