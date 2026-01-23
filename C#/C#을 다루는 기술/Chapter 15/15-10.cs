// 표현식 본문 메서드를 구현하기 위해서 switch 표현식을 사용

static double Perimeter(Shape shape) => 
    shape switch
    {
        null => throw new ArgumentNullException(nameof(shape)),
        Rectangle rect => 2 * (rect.Height + rect.Width),
        Circle circle => 2 * PI * Circle.Radius,
        Triangle triangle =>
            triangle.SideA + triangle.SideB + triangle.SideC,
        _ => throw new ArgumentNullException(
            $"Shape type {shape.GetType()} perimeter unknown",
            nameof(shape))
    };