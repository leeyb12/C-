// 예외 필터 내에서의 로깅

static void Main()
{
    try
    {
        UnreliableMethod();
    }
    catch (Exception e) when (Log(e))
    {
    }
}

static void UnreliableMethod()
{
    throw new Exception("Bang!");
}

static bool Log(Exception e)
{
    Console.WriteLine($"{DateTime.UtcNow}: {e.GetType()} {e.Message}");
    return false;
}