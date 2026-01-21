// (x, y) 좌표 검색과 중복 제거

var points = new[]
{
    (1, 2), (10, 3), (-1, 5), (2, 1),
    (10, 3), (2, 1), (1, 1)
};
var distinctPoints = points.Distinct();
Console.WriteLine($"{distinctPoints.Count()} distinct points");
Console.WriteLine("Points in order:");
foreach (var point in distinctPoints.OrderBy(p => p))
{
    Console.WriteLine(point);
}