// 예제 6-1의 MoveNext()를 역컴파일

void IAsyncStateMachine.MoveNext()
{
    int num = this.state;
    try
    {
        TaskAwaiter awaiter1;
        switch (num)
        {
            default:
                goto MethodStart;
            case 0:
                goto FirstAwaitContinuation;
            case 1:
                goto SecondAwaitContinuation;
        }
    MethodStart:
        Console.WriteLine("Before first delay");
        awaiter1 = Task.Delay(this.delay).GetAwaiter();
        if (awaiter1.IsCompleted)
        {
            goto GetFirstAwaitResult;
        }
        this.state = num = 0;
        this.awaiter = awaiter1;
        this.builder.AwaitUnsafeOnCompleted(ref awaiter1, ref this);
        return;
    FirstAwaitContinuation:
        awaiter1 = this.awaiter;
        this.awaiter = default(TaskAwaiter);
        this.state = num = -1;
    GetFirstAwaitResult:
        awaiter1.GetResult();
        Console.WriteLine("Between delays");
        TaskAwaiter awaiter2 = Task.Delay(this.delay).GetAwaiter();
        if (awaiter2.IsCompleted)
        {
            goto GetSecondAwaitResult;
        }
        this.state = num = 1;
        this.awaiter = awaiter2;
        this.builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
        return;
    SecondAwaitContinuation:
        awaiter2 = this.awaiter;
        this.awaiter = default(TaskAwaiter);
        this.state = num -1;
    GetSecondAwaitResult:
        awaiter2.GetResult();
        Console.WriteLine("After second delay");
    }
    catch (Exception exception)
    {
        this.state = -2;
        this.builder.SetException(exception);
        return;
    }
    this.state = -2;
    this.builder.SetResult();
}