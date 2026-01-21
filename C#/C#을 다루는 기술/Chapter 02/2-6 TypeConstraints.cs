// 타입 제약 조건을 설정하여 컬렉션 내의 요소들을 InvariantCulture를 이용하여 출력하는 예

static void PrintItems<T>(List<T> items) where T : IFormattable
{
    CultureInfo culture = CultureInfo.InvariantCulture;
    foreach (T item in items)
    {
        Console.WriteLine(item.ToString(null, culture));
    }
}