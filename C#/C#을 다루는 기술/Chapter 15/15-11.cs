// 중첩 패턴 매칭

static double Perimeter(Shape shape) => shape switch
{
    null => throw new ArgumentNullException(nameof(shape)),
    Rectangle { Height: var h, Width: var w } => 2 * (h + w),
    Circle { Radius: var r} => 2 * PI * r,
    Triangle { SideA: var a, SideB: var b, SideC: var c} => a + b + c,
    _ => throw new ArgumentException(
        $"Shape type {shape.GetType()} perimeter unknown", nameof(shape))
};