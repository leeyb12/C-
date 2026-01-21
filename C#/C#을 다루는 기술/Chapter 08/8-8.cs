// C# 3에서 자동 구현 속성을 포함하는 Person 클래스 선언

public class Person
{
    public List<Person> Friends { get; set; }  // 속성 선언. 초기화가 허용되지 않음

    public Person()
    {
        Friends = new List<Person>();  // 생성자 내부에서 속성 초기화
    }
}