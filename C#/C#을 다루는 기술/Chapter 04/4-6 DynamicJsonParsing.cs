// JSON 데이터를 동적으로 다루는 방법

// 하드코딩된 샘플 JSON 데이터
string json = @"
    {
      'name': 'Jon Skeet',
      'address': {
        'town': 'Reading',
        'country': 'UK'
      }
    }".Replace('\'', '"');

JObject obj1 = JObject.Parse(json);  // JSOM 데이터를 JObject로 파싱
Console.WriteLine(obj1["address"]["town"]);  // 정적으로 타입화된 뷰를 이용하는 예

// 동적으로 타입화된 뷰를 이용하는 예
dynamic obj2 = obj1;
Console.WriteLine(obj2.address.town);