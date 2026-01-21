// 웹 페이지의 내용을 가져올 때 예외가 발생하면 해당 예외를 잡음

async Task<string> FetchFirstSuccessfulAsync(IEnumerable<string> urls)
{
    var client = new HttpClient();
    foreach (string url in urls)
    {
        try
        {
            return await client.GetStringAsync(url);  // 성공하면 문자열 반환
        }
        catch (HttpRequestException exception)  // 실패하면 예외를 잡아서 출력
        {
            Console.WriteLine("Failed to fetch {0}: {1}",
                url, exception.Message);
        }
    }
    throw new HttpRequestException("No URLs succeeded");
}