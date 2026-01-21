// 디렉터리에 삽입할 타입을 지정한 Add 메서드 추가

static class PersonDicionaryExtensions
{
    public static void Add(
        this Dictionary<string, Person> dictionary, Person person)
    {
        dictionary.Add(person.Name, person);
    }
}