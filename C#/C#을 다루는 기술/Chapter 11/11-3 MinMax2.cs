// MinMax 내에 두 개의 지역 변수를 사용하지 않고 단일의 튜플을 사용

static (int min, int max) MinMax (IEnumerable<int> source)
{
    using (var iterator = source.GetEnumerator())
    {
        if (!iterator.MoveNext())
        {
            throw new InvalidOperationException(
                "Cannot find min/max of an empty sequence");
        }

        // 첫 번째 값을 이용하여 최솟값, 최댓값을 동시에 가지고 있는 튜플 생성
        var result = (min: iterator.Current,
                      max: iterator.Current);
        
        while (iterator.MoveNext())
        {
            // 튜플의 요소를 각각 수정
            result.min = Math.Min(result.min, iterator.Current);
            result.max = Math.Max(result.max, iterator.Current);
        }
        return result;  // 튜플을 직접 반환
    }
}