// Point를 두 개의 변수로 분해

var point = new Point(1.5, 20);  // Point 타입의 인스턴스를 생성
var (x, y) = point;  // 두 개의 double 타입 변수로 분해

// 변숫값을 각기 출력
Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");