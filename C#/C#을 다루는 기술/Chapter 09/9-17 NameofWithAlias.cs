// 별칭에 nameof 연산자를 사용

using System;

using GuidAlias = System.Guid;

class NameOfWithAliasTest
{
    static void Main()
    {
        Console.WriteLine(nameof(GuidAlias));
    }
}