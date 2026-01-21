// 루프 순회마다 문맥 정보를 저장할 인스턴스를 반복 생성

private class LambdaContext
{
    public string text;

    public void Method()
    {
        Console.WriteLine(text);
    }
}

static List<Action> CreateActions()
{
    List<Action> actions = new List<Action>();
    for (int i = 0; i < 5; i++)
    {
        LambdaContext context = new LambdaContext();  // 루프 순회 때마다 새로운 인스턴스 생성
        context.text = string.Format("message {0}", i);
        actions.Add(context.Method);  // action 생성 때마다 새롭게 생성한 인스턴스를 사용
    }
}