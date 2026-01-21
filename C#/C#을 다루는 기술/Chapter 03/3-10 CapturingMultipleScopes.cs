// 서로 다른 범위에 속한 여러 변수를 캡처

static List<Action> CreateCountingActions()
{
    List<Action> actions = new List<Action>();
    int outerCounter = 0;  // 두 개의 델리게이트에서 하나의 변수를 캡처
    for (int i = 0; i < 2; i++)
    {
        int innerCounter = 0;  // 루프 순회 때마다 새로운 변수를 생성
        Action action = () =>
        {
            // 변수의 값을 출력하고 증가시킴
            Console.WriteLine(
                "Outer: {0}; Inner: {1}",
                outerCounter, innerCounter);
            outerCounter++;
            innerCounter++;
        };
        actions.Add(action);
    }
    return actions;
}

// 코드의 다른 부분
List<Action> actions = CreateCountingActions();

// 각 델리게이트를 두 번씩 호출
actions[0]();
actions[0]();
actions[1]();
actions[1]();