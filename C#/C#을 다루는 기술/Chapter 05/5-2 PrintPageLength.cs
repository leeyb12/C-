// 비동기 메서드 내에서 웹 페이지의 길이를 획득

static readonly HttpClient client = new HttpClient();

static async Task<int> GetPageLengthAsync(string url)
{
    Task<string> fetchTextTask = client.GetStringAsync(url);
    int length = (await fetchTextTask).Length;
    return length;
}

static void PrintPageLength()
{
    Task<int> lengthTask = 
       GetPageLengthAsync("http://csharpindepth.com");
    Console.WriteLine(lengthTask.Result);
}