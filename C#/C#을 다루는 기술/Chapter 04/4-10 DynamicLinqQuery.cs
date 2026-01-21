// 동적 값의 예제에 대해 LINQ 쿼리 수행

List<dynamic> source = new List<dynamic>
{
    5,
    2.75,
    TimeSpan.FromSeconds(45)
};
IEnumerable<dynamic> query = source.Select(x => x * 2);
foreach (dynamic value in query)
{
    Console.WriteLine(value);
}