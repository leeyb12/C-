// null 가능 값 타입을 박싱한 결과

Nullable<int> noValue = new Nullable<int>();  
object noValueBoxed = noValue;  // HasValue가 false인 객체를 박싱
Console.WriteLine(noValueBoxed == null);  // true를 출력:박싱의 결과는 null 참조

Nullable<int> someValue = new Nullable<int>(5);
object someValueBoxed = someValue;  // HasValue가 true인 객체를 박싱
Console.WriteLine(someValueBoxed.GetType());  // System.Int32을 출력:박싱의 결과는 박싱된 int