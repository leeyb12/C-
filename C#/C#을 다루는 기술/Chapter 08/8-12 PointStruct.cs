// C# 6에서 자동 구현 속성을 포함하는 Point 구조체 작성

public struct Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}