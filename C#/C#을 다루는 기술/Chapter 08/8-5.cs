// C# 3의 자동 구현 속성에 private 세터를 선언하여 외부에서는 읽기만 가능하도록 속성을 구현한 Point 클래스

public sealed class Point
{
    public double X { get; private set; }
    public double Y { get; private set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}