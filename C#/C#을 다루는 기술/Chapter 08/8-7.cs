// C# 2에서 수동으로 구현한 속성을 포함하는 Person 클래스 선언

public class Person
{
    private List<Person> friends = new List<Person>();  // 필드 선언 및 초기화
    public List<Person> Friends  // 필드의 값을 읽고 쓰는 속성 노출 
    {
        get { return friends; }
        set { friends = value; }
    }
}