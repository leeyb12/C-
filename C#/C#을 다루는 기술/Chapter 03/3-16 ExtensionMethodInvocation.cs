// Noda Time 외부에서 정의한 ToInstant() 확장 메서드 호출

using NodaTime.Extensions;  // NodaTime.Extension 네임스페이스 사용
using System;

namespace CSharpInDepth.Chapter03
{
    class ExtensionMethodInvocation
    {
        static void Main()
        {
            var currentInstant = 
                DateTimeOffset.UtcNow.ToInstant();  // 확장 메서드 호출
            Console.WriteLine(currentInstant);
        }
    }
}