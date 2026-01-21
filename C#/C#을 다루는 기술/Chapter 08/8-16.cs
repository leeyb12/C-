// C# 6의 표현식 본문 메서드와 표현식 본문 연산자를 사용

public static Point Add(Point left, Vector right) => left + right;

public static Point operator+(Point left, Vector right) =>
    new Point(left.X + right.X, left.Y + right.Y);