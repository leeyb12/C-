// 생성자 내에서의 호출자 정보

public abstract class BaseClass
{
    protected BaseClass(  // 호출자 정보 특성을 사용하는 베이스 클래스 생성자
        [CallerFilePath] string file = "Unspecified file",
        [CallerLineNumber] int line = -1,
        [CallerMemberName] string member = "Unspecified member")
    {
        Console.WriteLine("{0}: {1} - {2}", file, line, member);
    }
}

public class Derived1 : BaseClass { }  // 매개변수 없는 생성자는 암시적으로 추가됨

public class Derived2 : BaseClass
{
    public Derived2() { }  // 생성자는 base()를 암시적으로 호출
}

public class Derived3 : BaseClass
{
    public Derived3() : base() {}  // base()를 명시적으호 호출
}