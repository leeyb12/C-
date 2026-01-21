// 제네릭 변성을 사용하지 않고 문자열에 대한 쿼리를 수행한 후 List<Object>를 생성

IEnumerable<string> strings = new[] { "a", "b", "cdefg", "hij" };
List<object> list = strings 
    .Where(x => x.Length > 1)
    .Cast<object>()
    .ToList();