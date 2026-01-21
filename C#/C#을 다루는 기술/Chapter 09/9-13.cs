// 본문 내에서 매개변수를 두 번 사용하는 간단한 메서드

static void RenameDemo(string oldName)
{
    Console.WriteLine($"{nameof(oldName)} = {oldName}");
}