// 동적 타이핑을 이용하여 부분 문자열 획득

dynamic text = "hello world";  // 변수를 동적 타입으로 선언
string world = text.Substring(6);  // Substring 메서드를 호출. 정상 동작
Console.WriteLine(world);

string broken = text.SUBSTR(6);  // SUBSTR 호출 시도. 예외 발생
Console.WriteLine(broken);