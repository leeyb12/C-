// 시퀀스를 순회하면서 로그를 출력하는 간단한 예

static void Main()
{
    foreach (string value in Iterator())
    {
        Console.WriteLine("Received value: {0}", value);
    }
}