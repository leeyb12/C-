// Deconstruct 오버로드 사용

// 날짜를 연/월/일로 분해
static void Deconstruct(
    this DateTime dateTime,
    out int year, out int month, out int day) => 
    (year, month, day) = 
    (dateTime.Year, dateTime.Month, dateTime.Day);

// 날짜를 연/월/일/시/분/초로 분해
static void Deconstruct(
    this DateTime dateTime,
    out int year, out int month, out int day,
    out int hour, out int minute, out int second) => 
    (year, month, day, hour, minute, second) =
    (dateTime.Year, dateTime.Month, dateTime.Day,
    dateTime.Hour, dateTime.Minute, dateTime.Second);

static void Main()
{
    DateTime birthday = new DateTime(1976, 6, 19);
    DateTime now = DateTime.UtcNow;

    var (year, month, day, hour, minute, second) = now;  // 여섯 개의 값으로 인스턴스를 분해하는 Deconstruct 사용
    (year, month, day) = birthday;  // 세 개의 인스턴스를 분해하는 Deconstruct 사용
}