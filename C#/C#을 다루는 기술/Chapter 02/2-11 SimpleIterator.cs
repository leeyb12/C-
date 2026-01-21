// 정숫값을 반환하는 간단한 이터레이터 구현

static IEnumerable<int> CreateSimpleIterator()
{
    yield return 10;
    for (int i = 0; i < 3; i++)
    {
        yield return i;
    }
    yield return 20;
}