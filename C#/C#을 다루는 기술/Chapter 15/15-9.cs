// switch 문을 switch 표현식으로 변경

static double Perimeter(Shape shape)
{
    return shape switch
    {
        null => throw new ArgumentNullException(nameof(shape)),
        Rectangle rect => 2 * (rect.Height + rect.Width),
        Circle circle => 2 * PI * circle.Radius,
        Triangle triangle =>
            triangle.SideA + triangle.SideB + triangle.SideC,
        _ => throw new ArgumentException(
            $"Shape type {shape.GetType()} perimeter unknown",
            nameof(shape)) 
    };
}