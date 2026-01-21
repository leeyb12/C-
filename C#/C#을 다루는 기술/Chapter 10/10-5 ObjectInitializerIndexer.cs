// StringBuilder 객체 초기화자 내에서 인덱서 사용

string Text = "This text needs truncating";
StringBuilder builder = new StringBuilder(text)
{
    Length = 10,  // 문자열을 치르기 위해 Length 속성 설정
    [9] = '\u2026'  // 마지막 문자를 '...'으로 변경
};
Console.OutputEncoding = Encoding.UTF8;  // 콘솔이 유니코드를 지원하도록 설정
Console.WriteLine(builder);