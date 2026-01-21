// 패턴을 사용하여 둘레 길이 계산

static double Perimeter(Shape shape)
{
    switch (shape)
    {
        // null 값 처리
        case null:
            throw new ArgumentNullException(nameof(shape));
        
        // 타입별 처리
        case Rectangle rect:
            return 2 * (rect.Height + rect.Width);
        case Circle circle:
            return 2 * PI * circle.Radius;
        case Triangle tri:
            return tri.SideA + tri.SideB + tri.SideC;

        // 무엇을 해야 할지 알 수 없다면 예외를 던짐
        default:
            throw new ArgumentNullException(...);
    }
}