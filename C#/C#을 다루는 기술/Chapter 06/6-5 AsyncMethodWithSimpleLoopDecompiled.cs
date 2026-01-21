// await 문이 하나만 있을 때(예제 6-3에서 수정할 부분만 발췌)

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