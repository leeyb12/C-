// 읽기 전용 자동 구현 속성을 포함하는 Point 클래스

public sealed class Point
{
    // 읽기 전용 자동 구현 속성 선언
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        // 생성자 내에서 속성 초기화
        X = x;
        Y = y;
    }
}