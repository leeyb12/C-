// 두 개의 partial 메서드. 하나는 구현하고 다른 하나는 구현하지 않음

partial class PartialMethodsDemo
{
    public PartialMethodsDemo()
    {
        OnConstruction();  // 구현하지 않은 partial 메서드를 호출
    }

    public override string ToString()
    {
        string ret = "Original return value";
        CustomizeToString(ref ret);  // 구현한 partial 메서드를 호출
        return ret;
    }

    // partial 메서드를 선언
    partial void OnConstruction();
    partial void CustomizeToString(ref string text);
}

partial class PartialMethodsDemo
{
    partial void CustomizeToString(ref string text)  // partial 메서드를 구현
    {
        text += " - customized!";
    }
}