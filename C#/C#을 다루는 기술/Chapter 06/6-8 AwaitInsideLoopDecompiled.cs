// 역컴파일 코드(언어의 루프 요소를 사용하지 않음)

switch (num)
    {
        default:
            goto MethodStart;
        case 0:
            goto AwaitContinuation;
    }
MethodStart:
    Console.WriteLine("Before loop");
    this.i = 0;  // 루프 카운터 초기화
    goto ForLoopCondition;  // 루프의 조건 비교문을 건너뜀
ForLoopBody:  // 루프 본문
    Console.WriteLine("Before await in loop");
    TaskAwaiter awaiter = Task.Delay(this.delay).GetAwaiter();
    if (awaiter.IsCompleted)
    {
        goto GetAwaitResult;
    }
    this.state = num = 0;
    this.awaiter = awaiter;
    this.builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
    return;
AwaitContinuation:  // 상태 머신을 재개할 때 점프해야 할 위치
    awaiter = this.awaiter;
    this.awaiter = default(TaskAwaiter);
    this.state = num = -1;
GetAwaitResult:
    awaiter.GetResult();
    Console.WriteLine("After await in loop");
    this.i++;  // 루프 카운터

// 루프 수행 조건을 확인하고, 만족하는 경우 일시 중지
ForLoopCondition:
    if (this.i < 3)
    {
        goto ForLoopBody;
    }
    Console.WriteLine("After loop delay");