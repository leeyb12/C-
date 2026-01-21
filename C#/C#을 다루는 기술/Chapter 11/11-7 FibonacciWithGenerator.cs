// 일반화된 메서드를 이용하여 피보나치 수열 생성

// 이전 값을 이용하여 새로운 값을 생성하는 시퀀스 생성기 메서드
static IEnumerable<TResult>
    GenerateSequence<TState, TResult>(
        TState seed,
        Func<TState, TState> generator,
        Func<TState, TResult> resultSelector)
{
    var state = seed;
    while (true)
    {
        yield return resultSelector(state);
        state = generator(state);
    }
}

// 사용 예

// 시퀀스 생성기를 이용하여 피보나치 수열을 생성
var fibonacci = GenerateSequence(
    (current: 0, next: 1),
    pair => (pair.next, pair.current + pair.next),
    pair => pair.current);