// Point에 DistanceFromOrigin 속성 추가

public sealed class Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // 거리를 계산하는 읽기 전용 속성
    public double DistanceFromOrigin
    {
        get { return Math.Sqrt(X * X + Y * Y); }
    }
}