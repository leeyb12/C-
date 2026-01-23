// 지역 메서드를 이용하지 않고 Select를 구현

public static IEnumerable<TResult> Select<TSource, TResult>(
    this IEnumerable<TSource> source,
    Func<TSource, TResult> selector)
{
    // 인수에 대한 유효성 검증
    Preconditions.CheckNotNull(source, nameof(source));
    Preconditions.CheckNotNull(
        selector, nameof(selector));
    return SelectImpl(source, selector);  // 구현은 위임
}

private static IEnumerable<TResult> SelectImpl<TSource, TResult>(
    IEnumerable<TSource> source,
    Func<TSource, TResult> selector)
{
    // 실제 구현부는 지연 수행
    foreach (TSource item in source)
    {
        yield return selector(item);
    }
}