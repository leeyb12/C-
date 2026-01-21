// 보간 문자열 리터럴 내에서의 정렬

decimal price = 95.25m;
decimal tip = price * 0.2m;  // 20% 팁

// 전체 길이를 아홉 글자로 맞추되 우측 정렬
Console.WriteLine($"Price: {price,9:C}");
Console.WriteLine($"Tip: {tip,9:C}");
Console.WriteLine($"Total: {price + tip,9:C}");