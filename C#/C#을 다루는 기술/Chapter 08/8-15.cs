// C# 5를 이용하여 단순한 메서드와 연산자 작성

public static Point Add(Point left, Vector right)
{
    return left + right;  // 연산자에 작업 위임
}

public static Point operator+(Point left, Vector right)
{
    // 덧셈 연산을 구현하기 위해서 생성자 호출
    return new Point(left.X + right.X,
        left.Y + right.Y);
}