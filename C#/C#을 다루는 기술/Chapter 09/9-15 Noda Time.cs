// nameof를 이용하여 테스트 케이스 생성

// TZDB 타임 존으로부터 모든 타임 존 정보 획득
static readonly IEnumerable<DateTimeZone> AllZones = 
    DateTimeZoneProviders.Tzdb.GetAllZones();

[Test]
[TestCaseSource(nameof(AllZones))]  // nameof를 이용하여 필드 참조
public void AllZonesStartAndEnd(DateTimeZone)  // 테스트 메서드가 타임 존별로 수행됨
{
    ...  // 테스트 메서드의 본문 생략
}