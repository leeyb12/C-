// 범위를 이용하여 문자열에서 첫 번째와 마지막 문자를 제거

string quotedText = "'This text was in quotes'";
Console.WriteLine(quotedText);
Console.WriteLine(quotedText.Substring(1..^1));  // Range 리터럴을 이용하여 주어진 문자열로부터 부분 문자열을 획득