// 패턴을 사용하지 않고 둘레 길이 계산

static double Perimeter(Shape shape)
{
    if (shape == null)
        throw new ArgumentNullException(nameof(shape));
    Rectangle rect = shape as Rectangle;
    if (rect != null)
        return 2 * (rect.Height + rect.Width);
    Circle circle = shape as Circle;
    if (circle != null)
        return 2 * PI * circle.Radius;
    Triangle triangle = shape as Triangle;
    if (triangle != null)
        return triangle.SideA + triangle.SideB + triangle.SideC;
    throw new ArgumnetNullException(
        $"Shape type {shape.GetType()} perimeter unknown", nameof(shape));
}