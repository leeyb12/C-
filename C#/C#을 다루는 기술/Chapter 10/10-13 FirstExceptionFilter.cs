// 세 개의 예외 중 두 개의 예외만 잡음

string[] messages = 
{
    "You can catch this",
    "You can catch this too",
    "This won't bbe caught"
};
foreach (string message in messages)  // try/catch 외부 루프로 예외 메시지당 한 번씩 순회
{
    try
    {
        throw new Exception(message);  // 매번 다른 예외 메시지로 예외를 던짐
    }
    catch (Exception e)
        when (e.Message.Contains("catch"))  // 예외 메시지에 "catch"가 포함된 경우에만 예외를 잡음
    {
        Console.WriteLine($"Caught '{e.Message}'");  // 예외 메시지 출력
    }
}