// C# 5에서 극 좌표를 직교 좌표로 변경

using System;
...
static Point PolarToCartesian(double degress, double magnitude)
{
    double radians = degress * Math.PI / 180;  // 도를 라다안으로 변경
    
    // 삼각법을 이용하여 변환 수행
    return new Point(
        Math.Cos(radians) * magnitude,
        Math.Sin(radians) * magnitude);
}