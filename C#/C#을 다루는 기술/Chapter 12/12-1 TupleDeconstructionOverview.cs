// 튜플을 이용한 분해 

var tuple = (10, "text");  // (int, string) 타입의 튜플 생성

var (a, b) = tuple;  // 새로운 변수 a, b로 암시적 분해

(int c, string d) = tuple;  // 새로운 변수 c, d로 명시적 분해

// 이미 존재하는 변수로 분해
int e;
string f;
(e, f) = tuple;

// 분해 작업 확인
Console.WriteLine($"a: {a}, b: {b}");
Console.WriteLine($"c: {c}, d: {d}");
Console.WriteLine($"e: {e}, f: {f}");