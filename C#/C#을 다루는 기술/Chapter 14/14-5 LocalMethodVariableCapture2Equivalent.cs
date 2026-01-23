// 예제 14-4를 로즐린이 변환한 결과

// 외부 범위를 나타내는 구조체 생성
struct OuterScope
{
    public int hour;
}

// 내부 범위를 나타내는 구조체 생성
struct InnerScope
{
    public int minute;
}

static void Main()
{
    DateTime now = DateTime.UtcNow;  // 캡처되지 않은 지역 변수

    // 외부 범위에서 선언된 hour 변수를 포함하는 구조체 생성/사용
    OuterScope outer = new OuterScope();
    outer.hour = now.Hour;

    if (outer.hour > 5) 
    {
        // 내부 범위에서 선언된 minute 변수를 포함하는 구조체 생성/사용
        InnerScope inner = new InnerScope();
        inner.minute = now.Minute;

        PrintValues(ref outer, ref inner);  // 추가로 생성한 메서드에 두 개의 구조체를 모두 참조로 결과
    }
}

// 지역 메서드를 이용하여 추가로 생성한 메서드
static void PrintValues(
    ref OuterScope outer, ref InnerScope inner)

{
    Console.WriteLine($"hour = {outer.hour}; minute = {inner.minute}");
}