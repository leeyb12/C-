// FormattableString조차도 표현식에 대해 이론(eager)평가를 수행함

string value = "Before";
FormattableString formattable = $"Current value: {value}";
Console.WriteLine(formattable);  // 'Current value: Before' 출력

value = "After";
Console.WriteLine(formattable);  // 여전히 'Current value: Before' 출력