// C# 6에서 읽기 전용 자동 구현 속성을 포함하는 Person 클래스 선언

public class Person
{
    // 읽기 전용 자동 구현 속성의 선언과 초기화
    public List<Person> Friends = { get; } =
        new List<Person>();
}