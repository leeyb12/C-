// 튜플을 이용한 피보나치 수열

static IEnumerable<int> Fibonacci()
{
    var pair = (current: 0, next: 1);
    while (true)
    {
        yield return pair.current;
        pair = (pair.next, pair.current + pair.next);
    }
}