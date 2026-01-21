// Noda Time 내의 위임 속성

public struct LocalDateTime
{
    public LocalDate Date { get; }  // 날짜 컴포넌트를 반환하는 속성

    // 날짜 컴포넌트로 위임
    public int Year => Date.Year;
    public int Month => Date.Month;
    public int Day => Date.Day;

    public LocalTime TimeOfDay { get; }  // 시간 컴포넌트를 반환하는 속성

    // 시간 컴포넌트로 위임
    public int Hour => TimeOfDay.Hour;
    public int Minute => TimeOfDay.Minute;
    public int Second => TimeOfDay.Second;

// 초기화, 기타 속성, 멤버 등
}