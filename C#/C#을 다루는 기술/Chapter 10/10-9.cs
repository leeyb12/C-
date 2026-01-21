// 확장 메서드를 통해 명시적 인터페이스 구현체를 노출

static class ListExtensions
{
    public static void Add<T>(this.List<T> list, IEnumerable<T> collection)
    {
        list.AddRange(collection);
    }
}