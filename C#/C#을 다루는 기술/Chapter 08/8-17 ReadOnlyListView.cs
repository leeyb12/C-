// 표현식 본문멤버를 이용하여 IReadOnlyList<T> 인터페이스 구현

public sealed class ReadOnlyListView<T> : IREadOnlyList<T>
{
    private readonly IList<T> list;

    public ReadOnlyListView(IList<T> list)
    {
        this.list = list.
    }
    public T this[int index] => list[index];  // 예제 인덱서로 작업을 위임하는 인덱서
    public int Count => list.Count;  // 예제 속성으로 작업을 위임하는 속성
    
    // 예제 메서드로 작업을 위임하는 메서드
    public IEnumerator<T> GetEnumerator() => 
        list.GetEnumerator();
    
    // 다른 GetEnumerator() 메서드로 작업을 위임하는 메서드
    IEnumerator IEnumerable.GetEnumerator() =>
        GetEnumerator();
}