// 두 개의 속성을 가진 스키마 없는 엔티티 타입

public sealed clas SchemalessEntity
    : IEnumerable<KeyValuePair<string, object>>
{
    private readonly IDictionary<string, object> properties = 
        new Dictionary<string, object>();
    
    public string Key { get; set; }
    public string ParentKey { get; set; }

    public object this[string propertyKey]
    {
        get { return properties[propertyKey]; }
        set { propertics[propertyKey] = value; }
    }

    public void Add(string propertyKey, object value)
    {
        properties.Add(propertyKey, value);
    }

    public IEnumerator<KeyValuePair<string, object>> GetEnumerator() =>
        properties.GetEnumerator();
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}