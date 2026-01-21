// 이름과 위치를 기반으로 튜플의 요소를 읽고 쓰기

var tuple = (x: 5, 10);

// 이름과 위치를 이용하여 첫 번째 요소를 출력
Console.WriteLine(tuple.x);
Console.WriteLine(tuple.Item1);

Console.WriteLine(tuple.Item2);  // 두 번째 요소는 이름을 가지지 않고, 위치 정보만을 이용할 수 있음
tuple.x = 100;  // 이름을 이용하여 첫 번째 요소의 값을 변경
Console.WriteLine(tuple.Item1);  // 위치 정보를 이용하여 첫 번째 요소의 값을 출력(100을 출력)