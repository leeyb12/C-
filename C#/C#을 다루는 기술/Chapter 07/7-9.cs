// 호출자 정보를 캡처하는 특성 클래스

[AttributeUsage(AttributeTargets.All)]
public class MemberDescriptionAttribute : Attribute
{
    public MemberDescriptionAttribute(
        [CallerFilePath] string file = "Unspecified file",
        [CallerLineNumber] int line = 0,
        [CallerMemberName] string member = "Unspecified member")
    {
        File = file;
        Line = line;
        Member = member;
    }

    public string File { get; }
    public int Line { get; }
    public string Member { get; }

    public override string ToString() =>
        $"{Path.GetFileName(File)}:{Line} - {Member}";
}