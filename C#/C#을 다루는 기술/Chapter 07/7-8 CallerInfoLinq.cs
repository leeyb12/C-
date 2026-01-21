// 쿼리 표현식 내에서의 호출자 정보

string[] source = 
{
    "the", "quick", "brown", "fox",
    "jumped", "over", "the", "lazy", "dog"
};

// 호출자 정보를 캡처하는 메서드를 사용하는 쿼리 표현식
var query = from word in source
            where word.Length > 3
            select word.ToUpperInvariant();
Console.WriteLine("Data:");
Console.WriteLine(string.Join(", ", query));  // 데이터 로깅
Console.WriteLine("CallerInfo:");

// 쿼리의 호출자 정보를 로깅
Console.WriteLine(string.Join(
    Environment.NewLine, query.CallerInfo));  
