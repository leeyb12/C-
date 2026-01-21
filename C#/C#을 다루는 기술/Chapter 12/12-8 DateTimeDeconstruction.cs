// DateTime을 분해하는 확장 메서드의 사용

// DateTime을 분해하는 확장 메서드
static void Deconstruct(
    this DateTime dateTime,
    out int year, out int month, out int day) =>
    (year, month, day) = 
    (dateTime.Year, dateTime.Month, dateTime.Day);

static void Main()
{
    DateTime now = DateTime.UtcNow;
    var (year, month, day) = now;  // 현재 날짜를 연/월/일로 분해
    Console.WriteLine(
        $"{year:0000}-{month:00}-{day:00}");  // 날짜를 가지고 있는 세 개의 변수를 출력
}