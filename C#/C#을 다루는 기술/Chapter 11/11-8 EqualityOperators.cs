// 같음 연산자와 같지 않음 연산자

var t1 = (x: "x", y: "y", z: 1);
var t2 = ("x", "y", 1);

Console.writeLine(t1 == t2);  // 같음 연산자

// 컴파일러가 생성한 코드
Console.WriteLine(t1.Item1 == t2.Item1 &&
                  t1.Item2 == t2.Item2 &&
                  t1.Item3 == t2.Item3);

Console.WriteLine(t1 != t2);  // 같지 않음 연산자

// 컴파일러가 생성한 코드
Console.WriteLine(t1.Item1 != t2.Item1 &&
                  t1.Item2 != t2.Item2 &&
                  t1.Item3 != t2.Item3);