// C# 6에서 극 좌표를 직교 좌표로 변경

using static System.Math;
...
static Point PolarToCartesian(double degrees, double magnitude)
{
    double radians = degress * PI / 180;  // 도를 라다안으로 변경

    // 삼각법을 이용하여 변환하여 수행
    return new Point(
        Cos(radians) * magnitude,
        Sin(radians) * magnitude);
}