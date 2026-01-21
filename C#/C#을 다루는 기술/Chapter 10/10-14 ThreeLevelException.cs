// 3레벨 예외 필터의 사용 예

// 예외 필터에서 사용하기 위한 용도로 작성된 메서드
static bool LogAndReturn(string message, bool result)
{
    Console.WriteLine(message);
    return result;
}

static void Top()
{
    try
    {
        throw new Exception();
    }

    // finally 블록(catch 없음)은 두 번째 단계에서 수행됨
    finally
    {
        Console.WriteLine("Top finally");
    }
}

static void Middle()
{
    try
    {
        Top();
    }
    catch (Exception e)
        when (LogAndReturn("Middle filter", false))  // catch되지 않도록 예외 필터 작성
    {
        Console.WriteLine("Caught in middle");  // 필터가 false를 반환하므로 이 내용은 출력되지 않음
    }

    // finally 블록은 두 번째 단계에서 수행됨
    finally
    {
        Console.WriteLine("Middle finally");
    }
}

static void Bottom()
{
    try
    {
        Middle();
    }
    catch (IOException e)
        when (LogAndReturn("Never called", true));  // 이 예외 필터는 호출되지 않음(예외 타입이 호환되지 않음)
}
{
    catch(Exception e)
        when (LogAndReturn("Bottom filter"), true);  // 항상 catch되는 예외 필터
    {
        Console.WriteLine("Caught in Bottom");  // 여기서 예외가 잡히기 때문에 이 내용이 출력됨
    }
}

static void Main()
{
    Bottom();
}