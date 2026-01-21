// as/if 대신 타입 패턴 사용

static double Perimeter(Shape shape)
{
    if (shape == null)
        throw new ArgumentNullException(nameof(shape));
    
}