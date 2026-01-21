// 지역 변수를 여러 번 인스턴스화

static List<Action> CreateActions()
{
    List<Action> actions = new List<Action>();
    for (int i = 0; i < 5; i++)
    {
        string text = string.Format("message {0}", i);  // 루프 내에서 지역 변수를 선언
        actions.Add(() => Console.WriteLine(text));  // 람다 표현식 내에서 변수를 캡쳐
    }
    return actions;
}

// 코드의 다른 부분
List<Action> actions = CreateActions();
foreach (Action action in actions)
{
    action();
}