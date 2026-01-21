// C# 7에 추가된 표현식 본문 멤버

public class Demo
{
    // 정적 생성자
    static Demo() =>
        Console.WriteLine("Static constructor called");

    ~Demo() => Console.WriteLine("Finalizer called");  // 종료자

    private string name;
    private readonly int[] values = new int[10];

    public Demo(string name) => this.name = name;  // 생성자

    private PropertyChangedEventHandler handler;

    // 사용자 정의 접근자를 가진 이벤트
    public event PropertyChangedEventHandler PropertyChanged
    {
        add => handler += value;
        remove => handler -= value;
    }

    // 읽기/쓰기 인덱서
    public int this[int index]
    {
        get => values[index];
        set => values[index] = value;
    }

    // 읽기/쓰기 속성
    public string name
    {
        get => name;
        set => name = value;
    }
}