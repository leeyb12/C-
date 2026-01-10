// 배열을 이용하여 이름을 저장하고 출력하는 예
static string[] GenerateNames()
{
    string[] names = new string[4];
    names[0] = "Gamma";
    names[1] = "Vlissides";
    names[2] = "Johnson";
    names[3] = "Helm";
    return names;
}

static void PrintNames(string[] names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}