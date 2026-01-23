// 생성자 초기화자 내에서 out 변수를 사용

class ParsedText
{
    public string Text { get; }
    public bool Valid { get; }

    protected ParsedText(string text, bool valid)
    {
        Text = text;
        Valid = valid;
    }
}

class ParsedInt32 : ParsedText
{
    public int? Value { get; }

    public ParsedInt32(string text)
        : base(text, int.TryParse(text, out int parseResult))
    {
        Value = Valid ? parseResult : (int?) null;
    }
}