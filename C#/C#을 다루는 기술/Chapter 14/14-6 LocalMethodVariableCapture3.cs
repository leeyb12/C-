// 지역 메서드의 메서드 그룹 변환

static void Main()
{
    Action counter = CreateCounter();

    // CreateCounter 메서드가 반환된 이후에 델리게이트를 수행
    counter();
    counter();
}

static Action CreateCounter()
{
    int counter = 0;  // Count 메서드에 의해 캡처된 지역 변수
    return Count;  // Count가 Action 델리게이트로 메서드 그룹 변환
    void Count() => Console.WriteLine(count++);  // 지역 메서드
}