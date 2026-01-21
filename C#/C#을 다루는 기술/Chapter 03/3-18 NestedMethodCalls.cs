// 확장 메서드를 사용하지 않은 쿼리

string[] words = { "keys", "coat", "laptop", "bottle" };
IEnumerable<string> query = 
    Enumerable.Select(
        Enumerable.OrderBy(
            Enumerable.Where(words, word => word.Length > 4),
            word => word),
    word => word.ToUpper());