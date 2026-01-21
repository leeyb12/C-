// 호출자 정보 특성과 동적 타이핑

// 이 메서드를 호출한 호출 측의 행 번호를 출력하는 메서드
static void ShowLine(string message,
    [CallerLineNumber] int line = 0)
{
    Console.WriteLine("{0}: {1}", line, message);
}

// 두 번째 대안을 위한 헬퍼 메서드
static int GetLineNumber(
    [CallerLineNumber] int line = 0)
{
    return line;
}

static void Main()
{
    dynamic message = "Some message";
    ShowInfo(message);  // 간단한 동적 메서드 호출: 행 번호로 0이 찍힌다.
    ShowInfo((string) message);  // 첫 번째 대안: 동적 타이핑을 제거하기 위해 값 타입 변환
    ShowInfo(message, GetLineNumber());  // 두 번째 대안: 헬퍼 메서드를 이용해서 행 번호를 명시적으로 지정
}