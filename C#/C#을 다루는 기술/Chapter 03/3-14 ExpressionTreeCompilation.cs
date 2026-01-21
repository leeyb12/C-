// 표현식 트리를 델리게이트로 컴파일하고 수행하여 결과를 얻어오는 예

Expression<Func<int, int, int>> adder = (x, y) => x + y;
Func<int, int, int> executableAdder = adder.Compile();  // 표현식 트리를 컴파일하여 델리게이트 생성
Console.WriteLine(executableAdder(2, 3));  // 델리게이트를 일반적인 방법으로 호출