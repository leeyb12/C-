// ArrayList를 이용하여 이름을 저장하고 출력하는 예

static ArrayList GenerateNames()
{
    ArrayList names = new ArrayList();
    names.Add("Gamma");
    names.Add("Johnson");
    names.Add("Helm");
    return names;
}
static void PrintNames(ArrayList names)
{
    foreach (string name in names) 
    {
        Console.WriteLine(name);
    }
}