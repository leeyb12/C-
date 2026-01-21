// 캡쳐된 변수를 가지는 람다 표현식의 변환 결과

private class LambdaContext  // 캡쳐된 변수를 저장하기 위해 생성된 클래스
{
    // 캡쳐된 변수
    public CapturedVariablesDemoImpl originalThis;
    public string methodParameter;
    public string methodLocal;

    public void Method(string lambdaParameter)  // 람다 표현식의 본문은 인스턴스 메서드로 변환
    {
        string lambdaLocal = "lambda local";
        Console.WriteLine("Instance field: {0}", originalThis.instanceField);
        Console.WriteLine("Method parameter: {0}", methodParameter);
        Console.WriteLine("Method local: {0}", methodLocal);
        Console.WriteLine("Lambda parameter: {0}", lambdaParameter);
        Console.WriteLine("Lambda local: {0}", lambdaLocal);
    }
}

public Action<string> CreateAction(string methodParameter)
{
    // 생성된 클래스는 캡쳐된 변수에 접근할 때 사용됨
    LambdaContext context = new LambdaContext();
    context.originalThis = this;
    context.methodParameter = methodParameter;
    context.methodLocal = "method local";
    string uncaptured = "uncaptured local";

    Action<string> action = context.Method;
    context.methodLocal = "modified method local";
    return action;
}