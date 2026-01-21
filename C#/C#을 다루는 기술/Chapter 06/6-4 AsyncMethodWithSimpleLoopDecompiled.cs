// MoveNext() 메서드를 의사 코드로 작성

void IAsyncStateMachine.MoveNext()
{
    try
    {
        switch (this.state)
        {
            default: goto MethodStart;
            case 0: goto Label0A;
            case 1: goto Label1A;
            case 2: goto Label2A;
            // 대기 표현식의 개수만큼 case 문이 존재
        }
    MethodStart:
            // 첫 번째 대기 표현식 이전 코드
            // 첫 번째 대기자 셋업
    Label0A:
            // 컨티뉴에이션부터 수행 재개
    Label0B:
            // 빠른 경로와 느린 경로가 합쳐짐
            // 추가 레이블과 대기자 등을 포함하는 코드
    }

    // 빌더를 통해 모든 예외를 전파
    catch (Exception e)
    {
        this.state = -2;
        builder.SerException(e);
        return;
    }

    // 빌더를 통해 메서드 완료를 전파
    this.state = -2;
    builder.SetResult();
}