// 문자열에 대한 쿼리

string[] words = { "keys", "coat", "laptop", "bottle" };  // 단순한 데이터 소스
IEnumerable<string> query = words

    // 필터, 정렬, 변환
    .Where(word => word.Length > 4)
    .OrderBy(word => word)
    .Select(word => word.ToUpper());

// 결과 출력
foreach (string word in query)
{
    Console.WriteLine(word);
}