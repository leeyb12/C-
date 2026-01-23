// 비동기 숫자 시퀀스 생성

static async IAsyncEnumerable<int> RangeAsync(
    int start, int count,
    CancellationToken cancellationToken = default)
{
    for (int i = 0; i < count; i++)
    {
        await Task.Delay(i, cancellationToken);
        yield return start + i;
    }
}