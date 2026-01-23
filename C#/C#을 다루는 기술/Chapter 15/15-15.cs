// string과 Span에 대해 Index와 Range를 취하는 인덱서 오버로드의 활용

string text = "hello world";
Console.WriteLine(text[2]);  // 시작 위치로부터 이동하여 단일 문자에 접근
Console.WriteLine(text[^3]);  // 끝 위치로부터 이동하여 단일 문자에 접근
Console.WriteLine(text[2..7]);  // Range를 이용하여 부분 문자열 획득

Span<int> span = stackalloc int[] { 5, 2, 7, 8, 2, 4, 3 };
Console.WriteLine(span[2]);  // 시작 위치로부터 이동하여 단일 요소 접근
Console.WriteLine(span[^3]);  // 끝 위치로부터 이동하여 단일 요소 접근
Span<int> slice = span[2..7];  // Range를 이용하여 슬라이스 생성
Console.WriteLine(string.Join(", ", slice.ToArray()));