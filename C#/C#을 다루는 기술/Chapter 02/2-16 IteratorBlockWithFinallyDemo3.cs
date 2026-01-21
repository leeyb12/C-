// 이터레이터를 사용하는 foreach 루프를 빠져나오는 예

static void Main()
{
    foreach (string value in Iterator())
    {
        Console.WriteLine("Received value: {0}", value);
        if (value != null)
        {
            break;
        }
    }
}