// 예제 6-1을 역컴파일하고 개선한 코드(MoveNext 제외)

// 스텁 메서드
[AsyncStateMachine(typeof(PrintAndWaitStateMachine))]
[DebuggerStepThrough]
private static unsafe Task PrintAndWait(TimeSpan delay)
{
    // 메서드 매개변수를 포함하여 상태 머신 초기화
    var machine = new PrintAndWaitStateMachine
    {
        delay = delay;
        builder = AsyncTaskMethodBuilder.Create(),
        state = -1
    };
    machine.builder.Start(ref machine);  // 대기해야 할 때까지 상태 머신 수행
    return machine.builder.Task;  // 비동기 작업을 나타내는 Task 객체 반환
}

// 상태 머신을 위한 private 구조체
[CompilerGenerated]
private struct PrintAndWaitStateMachine : IAsyncStateMachine
{
    public int state;  // 상태 머신의 상태(재시작 시)
    public AsyncTaskMethodBuilder builder;  // 비동기 내부 구조 안에 빌더 참조를 둠
    private TaskAwaiter awaiter;  // 재시작 시 결과를 가져오기 위한 대기자
    public TimeSpan delay;  // 메서드의 매개변수

    // 상태 머신이 주로 수행되는 위치
    void IAsyncStateMachine.MoveNext()
    {
    }

    [DebuggerHidden]
    void IAsyncStateMachine.SetStateMachine(
        IAsyncStateMachine stateMachine)
    {
        this.builder.SetStateMachine(stateMachine);  // 빌더와 박싱된 상태 머신을 연결
    }
}