// Invariant 컬처를 이용한 날짜 포매팅

DateTime date = DateTime.UtcNow;

// string.Format을 이용한 예전 방식
string parameter1 = string.Format(
    CultureInfo.InvariantCulture,
    "x={0:yyyy-MM-dd}",
    date);

// FormattableString으로 타입 변환을 수행한 후 ToString(IFormatProvider)를 호출
string parameter2 =
    ((FormatableString)$"x={date:yyyy-MM-dd}");
    .ToString(CultureInfo.InvariantCulture);

// FormattableString.Invariant를 호출하는 전형적인 방식
string parameter3 = FormattableString.Invariant(
    $"x={date:yyyy-MM-dd}");

// FormattableString.Invariant를 호출하는 축약된 방식
string parameter4 = Invariant($"x={date:yyyy-MM-dd}");