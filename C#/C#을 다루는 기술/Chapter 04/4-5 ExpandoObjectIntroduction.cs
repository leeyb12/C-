// ExpandoObject에 값을 저장하고 획득하는 방법

dynamic expando = new ExpandoObject();
expando.SomeData = "Some data";  // 데이터를 속성에 저장

// 델리게이트를 속성에 저장
Action<string> action = 
    input => Console.WriteLine("The input was '{0}'", input);
expando.FakeMethod = action;

// 데이터와 속성에 동적으로 접근
Console.WriteLine(expando.SomeData);
expando.FakeMethod("hello");

// 키를 출력하기 위해서 ExpandoObject를 디렉터리처럼 다름
IDictionary<string, object> dictionary = expando;
Console.WriteLine("Keys: {0}", string.Join(", ", dictionary.Keys));

// 정적 컨텍스트를 사용하여 데이터를 채우고 동적 값에서 데이터를 가져옴
dictionary["OtherData"] = "other";
Console.WriteLine(expando.OtherData);