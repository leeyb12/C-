// 정적 클래스 살펴보기

static class StaticClassDemo
{
    public static void StaticMethod() { }  // 옳음: 정적 클래스는 정적 메서드만 선언할 수 있음

    public void InstanceMethod() { } // 틀림: 정적 클래스에는 인스턴스 메서드를 선언할 수 있음

    public class RegularNestedClass  // 옳음: 정적 클래스는 일반적인 중첩 타입을 포함할 수 있음
    {
        public void InstanceMethod() { }  // 옳음: 정적 클래스 내의 일반적인 중첩 타입은 인스턴스 메서드를 포함할 수 있음
    }
}
...
StaticClassDemo.StaticMethod();  // 옳음: 정적 클래스 내에서 정적 메서드의 호출은 허용

StaticClassDemo localVariable = null;  // 틀림: 정적 클래스에는 변수를 선언할 수 없음

// 틀림: 정적 클래스를 타입 매개변수로 사용할 수 없음
List<StaticClassDemo> list = 
    new List<StaticClassDemo>();