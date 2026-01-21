//  for 루프 내에서 반복 변수 캡처

List<string> names = new List<string> { "x", "y", "z" };
var actions = new List<Action>();
for (int i = 0; i < names.Count; i++)  // 예제를 순회하기 위한 반복 변수
{
    actions.Add(() => Console.WriteLine(names[i]));  // name과 i를 캡처하는 델리게이트 생성
}

// 생성한 델리게이트를 모두 수행
foreach (Action action in actions)
{
    action();
}
