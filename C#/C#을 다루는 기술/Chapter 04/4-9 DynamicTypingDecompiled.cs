// 두 가지 동적 작업을 수행하는 코드를 역컴파일한 결과

using Microsoft.CSharp.RuntimeBinder;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class DynamicTypingDecompiled
{
    private static class CallSites  // 콜 사이트를 캐시
    {
        public static CallSite<Func<CallSite, object, int, object>> method;
        public static CallSite<Func<CallSite, object, string>> conversion;
    }

    static void Main()
    {
        object text = "hello world";
        if (CallSites.method == null)  // 필요하다면 메서드를 위한 콜 사이트 생성
        {
            CSharpArgumentInfo[] argumentInfo = new[]
            {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant |
                        CSharpArgumentInfoFlags.UseCompileTimeType, null)
            };
            CallSiteBinder binder =
                Binder.InvokeMember(CSharpBinderFlags.None, "Substring",
                    null, typeof(DynamicTypingDecompiled), argumentInfo);
            CallSites.method = 
                CallSite<Func<CallSite, object, int, object>>.Create(binder);
        }

        if (CallSites.conversion == null)  // 필요하다면 타입 변환을 위한 콜 사이트 생성
        {
            CallSiteBinder binder = 
                Binder.Convert(CSharpBinderFlags.None, typeof(string),
                    typeof(DynamicTypingDecompiled));
            CallSites.conversion = 
                CallSite<Func<CallSite, object, string>>.Create(binder);
        }

        // 메서드 콜 사이트 호출
        object result = CallSites.method.Target(
            CallSites.method, text, 6);
        string str =  // 타입 변환 콜 사이트 호출
            CallSites.conversion.Target(CallSities.conversion, result);
    }
}