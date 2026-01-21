// 서로 다른 범위에 속한 여러 변수를 캡처하면 여러 클래스가 생성됨

// 외부 범위에 대한 문맥
private class OuterContext
{
    public int outerCounter;
}

// 내부 범위에 대한 문맥은 외부 범위에 대한 참조를 포함하고 있음
private class InnerContext
{
    public OuterContext outerContext;
    public int innerCounter;

    public void Method()  // 델리게이트를 위해 생성된 메서드
    {
        Console.WriteLine(
            "Outer: {0}; Inner: {1}",
            outerContext.outCounter, innerCounter);
        outerContext.outerCounter++;
        innerCounter++;
    }
}

static List<Action> CreateCountingActions()
{
    List<Action> actions = new List<Action>();
    OuterContext outerContext = new OuerContext();  // 외부 범위에 대한 문맥은 하나만 생성
    outerContext.outerCounter = 0;
    for (int i = 0; i < 2; i++) 
    {
        // 내부 문맥은 루프 반복마다 생성
        InnerContext innerContext = new InnerContext();
        innerContext.outerContext = outerContext;
        innerContext.innerCounter = 0;

        Action action = innerContext.Method;
        actions.Add(action);
    }
    return actions;
}