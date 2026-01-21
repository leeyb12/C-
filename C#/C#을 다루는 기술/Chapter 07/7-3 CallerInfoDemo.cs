// 호출자 정보 특성의 기본적인 사용 예

static void ShowInfo(
    [CallerFilePath] string file = null,
    [CallerLineNumber] int line = 0,
    [CallerMemberName] string member = null)
{
    Console.WriteLine("{0}:{1} - {2}", file, line, member);
}

static void Main()
{
    ShowInfo();  // 컴파일러가 세 개의 매개변수 모두에 값을 지정한다.
    ShowInfo("LiesAndDamnedLies.java", -10);  // 컴파일러가 멤버 매개변수에 대해서만 값을 지정한다.
}