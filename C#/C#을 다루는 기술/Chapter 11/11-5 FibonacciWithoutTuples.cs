// 튜플을 사용하지 않고 구현한 피보나치 수열

static IEnumerable<int> Fibonacci()
{
    int current = 0;
    int next = 1;
    while (true)
    {
        yield return current;
        int nextNext = current + next;
        current = next;
        next = nextNext;
    }
}