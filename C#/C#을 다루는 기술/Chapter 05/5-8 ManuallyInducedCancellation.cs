// OperationCanceledException 예외를 던져서 Task 객체의 Status를 확인

static async Task ThrowCancellationException()
{
    throw new OperationCanceledException();
}
...
Task task = ThrowCancellationException();
Console.WriteLine(task.Status);