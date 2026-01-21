// C# 5의 자동 구현 속성을 포함하는 Point 구조체 

public struct Point
{
    // public 게터와 private 세터를 가진 속성
    public double X { get; private set; }
    public double Y { get; private set; }

    public Point(double x, double y) : this()  // 기본 생성자 연쇄 호출    
    {
        // 속성 초기화
        X = x;
        Y = y;
    }
}