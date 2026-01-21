// 간단한 partial 클래스

partial clas PartialDemo
{
    public static void MethodInPart1()
    {
        MethodInPart2();  // 다른 부분에서 선언한 메서드를 사용
    }
}

partial class PartialDemo
{
    private static void MethodInPart2()  // 다른 부분에서 사용한 메서드
    {
        Console.WriteLine("In MethodInPart2");
    }
}