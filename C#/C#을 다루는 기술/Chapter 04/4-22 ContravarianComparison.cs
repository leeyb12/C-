// IComparer<Shape>를 이용하여 List<Circle>을 정렬

List<Circle> circles = new List<Circle>
{
    new Circle(5,3),
    new Circle(2),
    new Circle(10.5)
};
circles.Sort(new AreaComparer());
foreach (Circle circle in circles)
{
    Console.WriteLine(circle.Radius);
}