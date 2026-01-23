// 예제 14-6을 로즐린이 변환한 결과

static void Main()
{
    Action counter = CreateCounter();
    counter();
    counter();
}

static Action CreateCounter()
{
    // 캡처된 변수를 포함하는 객체를 생성/초기화
    CountHolder holder = new CountHolder();
    holder.count = 0;

    return holder.Count;  // holder를 이용하여 인스턴스 메서드로의 메서드 그룹 변환을 수행
}

private class CountHolder  // 캡처된 변수와 지역 메서드를 포함한느 private 클래스
{
    public int count;  // 캡처된 변수
    public void Count() => Console.WriteLine(count++);  // 지역 메서드는 이제 새롭게 생성한 클래스의 인스턴스 메서드가 됨
}