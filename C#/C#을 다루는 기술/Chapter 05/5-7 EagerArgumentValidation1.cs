// 인수에 대한 유효성 검증 후, 독립적으로 작성된 비동기 메서드를 사용하는 방법

static Task<int> ComputeLengthAsync(string text)  // 비동기가 아닌 메서드이므로 예외가 Task 객체 내에 머무르지 않음
{
    if (text == null)
    {
        throw new ArgumentNullException("text");
    }
    return ComputeLengthAsyncImpl(text);  // 인수에 대한 유효성 검증 후, 실제 구현 메서드로 작업 위임
}

static async Task<int> ComputeLengthAsyncImpl(string text)
{
    await Task.Delay(500);  // 인수는 이미 검증되었음을 감안하여 비동기 메서드를 구현
    return text.Length;
}