// 가격, 팁, 합을 정렬하여 출력

decimal price = 95.25m;
decimal tip = price * 0.2m;  // 팁은 20%
Console.WriteLine("Price: {0,9:C}", price);
Console.WriteLine("Tip: {0,9:C}", tip);
Console.WriteLine("Total: {0,9:C}", price + tip);