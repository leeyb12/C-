// 파일에서 한 행씩 읽어오는 예제

static IEnumerable<string> ReadLines(string path)
{
    using (TextReader reader = File.OpenText(path))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            yield return line;
        }
    }
}