// 확장 메서드를 이용하여 명시적으로 구현한 인터페이스를 노출

public static class DictionaryExtensions
{
    public static void Add<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        TKey key, TValue value)
    {
        dictionary.Add(key, value);
    }
}