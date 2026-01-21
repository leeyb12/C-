// MinMax 메서드 내에서 결과 튜플의 값을 재할당하는 코드

static (int min, int max) MinMax (IEnumerable<int> source)
{
    using (var iterator = source.GetEnumerator())
    {
        if (!iterator.MoveNext())
        {
            throw new InvalidOperationException(
                "Cannot find min/max of an empty sequence");
        }
        var result = (min: iterator.Current, max: iterator.Current);
        while (iterator.MoveNext())
        {
            // result에 새로운 값을 할당
            result = (Math.Min(result.min, iterator.Current),
                     Math.Max(result.max, iterator.Current));
        }
        return result;
    }
}