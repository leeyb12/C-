// 두 정숫값을 더하는 간단한 표현식 트리

Expreesion<Func<int, int, int>> addr = (x, y) => x + y;
Console.WriteLine(addr);