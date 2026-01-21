// null 가능 값 타입에 대해 GetType()을 호출했을 때의 놀라운 결과

Nullable<int> noValue = new Nullable<int>();
// Console.WriteLine(noValue, GetType());  // NullReferenceException을 유발함

Nullable<int> someValue = new Nullable<int>(5);
Console.WriteLine(someValue.GetType());  // System.Int32를 출력. 이는 typeof(int)의 결과와 동일