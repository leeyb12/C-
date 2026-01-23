// 이터레이터를 이용하여 ListCitiesAsync 구현

public async IAsyncEnumerable<string> ListCitiesAsync()
{
    string pageToken = null;
    do
    {
        var request = new ListCitiesRequest(pageToken);
        var response = await service.ListCitiesAsync(request);
        foreach (var city in response.Cities)
        {
            yield return city;
        }
        pageToken = response.NextPageToken();
    } while (pageToken != null);
}