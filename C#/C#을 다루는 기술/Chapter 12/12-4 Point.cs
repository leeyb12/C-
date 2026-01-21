// 튜플 리터럴과 분해를 이용하영 생성자 내의 할당문을 단순화

public sealed class Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y) => (X, Y) = (x, y);
}