// SimpleDynamicExample 구현

class SimpleDynamicExample : DynamicObject
{
    // 메서드 호출 처리
    public override bool TryInvokeMember(
        InvokeMemberBinder binder,
        object[] args, 
        out object result)
    {
        Console.WriteLine("Invoked: {0}({1})",
            binder.Name, string.Join(", ", args));
        result = null;
        return true;       
    }

    // 속성 접근 처리
    public override bool TryGetMember(
        GetMemberBinder binder,
        out object result)
    {
        result = "Fetched: " + binder.Name;
        return true; 
    }
}