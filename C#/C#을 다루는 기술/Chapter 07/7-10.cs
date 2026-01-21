// MemberDescriptionAttribute 특성을 클래스와 메서드에 적용

using MOA = MemberDescriptionAttribute;  // 리플렉션 코드를 간략히 쓸 수 있도록 함
...

// 해당 특성을 클래스에 적용
[MemberDescription]
class CallerNameInAttribute
{
    // 해당 특성을 메서드에 다양한 방법으로 적용
    [MemberDescription]
    public void Method<[MemberDescription] T>(
        [MemberDescription] int parameter) { }
    
    static void Main()
    {
        var typeInfo = typeof(CallerNameInAttribute).GetTypeInfo();
        var methodInfo = typeInfo.GetDeclaredMethod("Method");
        var paramInfo = methodInfo.GetParameters()[0];
        var typeParamInfo = 
            methodInfo.GetGenericArguments()[0].GetTypeInfo();
        Console.WriteLine(typeInfo.GetCustomAttribute<MDA>());
        Console.WriteLine(methodInfo.GetCustomAttribute<MDA>());
        Console.WriteLine(paramInfo.GetCustomAttribute<MDA>());
        Console.WriteLine(typeParamInfo.GetCustomAttribute<MDA>());
    }
}