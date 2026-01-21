// C# 6에서 (읽고 쓸 수 있는) 자동 구현 속성을 포함하는 Person 클래스 선언

public class Person
{
    // 읽고 쓸 수 있는 자동 구현 속성의 선언과 초기화
    public List<Person> Friends { get; set; } = 
        new List<Person>();
}