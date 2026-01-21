// 쿼리를 여러 문장으로 분리

string[] words = { "keys", "coat", "laptop", "bottle" };
var tmp1 = Enumerable.Where(words, word => word.Length > 4);
var tmp2 = Enumerable.OrderBy(tmp1, word => word);
var tmp3 = Enumerable.Select(tmp2, word => word.ToUpper());