// 지역 메서드를 이용하여 Select를 구현

public static IEnumerable<TResult> Select<TSource, TResult>(
    this IEnumerable<TSource> source,
    Func<TSource, TResult> selector)
{
    Preconditions.CheckNotNull(source, nameof(source));
    Preconditions.CheckNotNull(selector, nameof(selector));
    return SelectImpl(source, selector);

    IEnumerable<TResult> SelectImpl(
        IEnumerable<TSource> validatedSource,
        Func<TSource, TResult> validatedSelector)
    {
        foreach (TSource item in validatedSource)
        {
            yield return validatedSelector(item);
        }
    }
}