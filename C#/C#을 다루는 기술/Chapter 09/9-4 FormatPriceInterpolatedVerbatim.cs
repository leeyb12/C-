// 보간 축자 문자열 리터럴을 하나만 사용해서 정렬된 값을 출력

decimal price = 95.25m;
decimal tip = price * 0.2m;  // 20% 팁
Console.WriteLine($@"Price: {price,9:C}
Tip: {tip,9:C}
Total: {price + tip,9:C}");