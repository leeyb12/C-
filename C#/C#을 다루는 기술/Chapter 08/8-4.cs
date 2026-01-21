// C# 3에서 수동으로 구현한 읽기 전용 속성을 포함하는 Point 클래스

public sealed class Point
{
    private readonly double x, y;  // 읽기 전용 필드

    // 필드의 값을 반환하는 읽기 전용 속성
    public double X { get { return x; } }
    public double Y { get { return y; } }

    public Point(double x, double y)
    {
        // 생성 시에 필드 값을 초기화
        this.x = x;
        this.y = y;
    }
}