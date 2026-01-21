// try/finally 내부에 await가 있는 코드 역컴파일

switch (num)
    {
        default:
            goto MethodStart;
        case 0:
            goto AwaitContinuationTrampoline;  // 트램펄린 코드 앞쪽으로 점프한다.이후에 올바른 위치로 다시 점프할 것이다.
    }
MethodStart:
    Console.WriteLine("Before try");
AwaitContinuationTrampoline:
    try
    {
        // try 블록 내의 트램펄린 코드
        switch (num)
        {
            default:
                goto TryBlockStart;
            case 0:
                goto AwaitContinuation;
        }
    TryBlockStart:
        Console.WriteLine("Before await");
        TaskAwaiter awaiter = Task.Delay(this.delay).GetAwaiter();
        if (awaiter.IsCompleted)
        {
            goto GetAwaiterResult;
        }
        this.state = num = 0;
        this.awaiter = awaiter;
        this.builder.AwaiterUnsafeOnCompleted(ref awaiter, ref this);
        return;
    AwaitContinuation:  // 실제 컨티뉴에이션 위치
        awaiter = this.awaiter;
        this.awaiter = default(TaskAwaiter);
        this.state = num = -1;
    GetAwaitResult:
        awaiter.GetResult();
        Console.WriteLine("After await");
    }
    finally
    {
        // 일시 중단해야 하는 경우 원래 코드의 finally 블록은 수행하지 않음
        if (num < 0)
        {
            Console.WriteLine("In finally block");
        }
    }
    Console.WriteLine("After finally block");