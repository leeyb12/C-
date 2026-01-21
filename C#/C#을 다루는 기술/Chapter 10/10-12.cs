// null 조건 연산자를 적용하기 쉬운 로깅 API

public interface ILogger  // GetLog 메서드가 반환하는 인터페이스 등
{
    // 로깅을 중지하면 속성은 null를 반환
    IActiveLogger Debug { get; }
    IActionLogger Info { get; }
    IActionLogger Warning { get; }
    IActionLogger Error { get; }
}

public interface IActionLogger  // 로깅 작업을 표현하는 인터페이스
{
    void Log(string message);
}