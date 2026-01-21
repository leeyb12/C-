// 익명 타입의 속성을 동적으로 접근

static void PrintName(dynamic obj)
{
    Console.WriteLine(obj.Name);
}

static void Main()
{
    var x = new { Name = "Abc" };
    var y = new { Name = "Def", Score = 10 };
    PrintName(x);
    PrintName(y);
}