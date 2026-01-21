// 이터레이터에 대해 컴파일러가 생성한 코드의 기반 구조

public static IEnumerable<int> GenerateIntegers(  // 원래 선언된 메서드의 원형을 유지하기 위한
    int count)                                   // 스텁 메서드(stub method)
{
    GeneratedClass ret = new GeneratedClass(-2);
    ret.count = count;
    return ret;
}

private class GeneratedClass
    : IEnumerable<int>, IEnumerator<int>  
// 상태 머신을 나타내기 위해 생성한 클래스
{
    // 상태 머신 내에서 여러 목적으로 사용되는 필드들
    public int count;
    private int state;
    private int current;
    private int initialThreadId;
    private int i;

    public GeneratedClass(int state)  // 스텁 메서드와 GetEnumerator가 호출하는 생성자
    {
        this.state = state;
        initialThreadId = Environment.CurrentManagedThreadId;
    }

    public bool MoveNext() { ... }  // 상태 머신 코드의 본문

    public IEnumerator<int> GetEnumerator() { ... }  // 필요한 경우 새로운 상태 머신을 생성

    public void Reset()
    {
        throw new NotSupportedException();  // 생성된 이터레이터는 Reset을 지원하지 않음
    }

    public void Dispose() { ... }  // 필요한 경우 finally 블록의 본문을 수행

    public int Current { get { return current; } }  // 반환할 값을 얻을 수 있는 Current 속성

    private void Finally1() { ... }  // MoveNext와 Dispose에서 사용하는 finally 블록의 본문

    // 제네릭이 아닌 일반 인터페이스에 속한 메서드의 명시적 구현
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    object IEnumerator.Current { get { return current; } }
}