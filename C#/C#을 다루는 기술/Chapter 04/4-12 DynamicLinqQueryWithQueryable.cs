// IQueryable<T>의 타입 매개변수로 dynamic을 사용

List<dynamic> source = new List<dynamic>
{
    5,
    2.75,
    TimeSpan.FromSeconds(45)
};
IEnumerable<dynamic> query = source
    .AsQueryable()
    .Select(x => x * 2);  // 컴파일 실패 발생
    