// 정숫값의 시퀀스로부터 최솟값과 최댓값을 단일 튜플로 반환하는 예

static (int min, int max) MinMax(  // 개별 요소에 이름을 명명한 튜플 타입을 반환
    IEnumerable<int> source)
{
    using (var iterator = source.GetEnumerator())
    {
        if (!iterator.MoveNext())  // 빈 시퀀스는 금지
        {
            throw new InvalidOperationException(
                "Cannot fin min/max of an empty sequence");
        }
        // 최솟값과 최댓값을 추적하기 위한 일반 int 변수
        int min = iterator.Current;
        int max = iterator.Current;

        while (iterator.MoveNext())
        {
            // 새로운 최솟값과 최댓값으로 변수를 갱신
            min = Math.Min(min, iterator.Current);
            max = Math.Max(max, iterator.Current);
        }
        return (min, max);  // 최솟값, 최댓값을 튜플로 생성
    }
}