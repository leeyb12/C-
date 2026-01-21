// StringCollection을 이용하여 이름을 저장하고 출력하는 예

static StringCollection GeneraateNames()
{
    stringCollection names = new StringCollection();
    names.Add("Gamma");
    names.Add("Vlissides");
    names.Add("Johnson");
    names.Add("Helm");
    return names;
}

static void PrintNames(stringCollection names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}