// 중첩 객체 초기화 구문을 이용하여 새롭게 생성한 HttpClient 객체의 기본 헤더 값을 수정하는 예

HttpClient client = new HttpClient
{
    DefaultRequestHeaders = // DefaultRequestHeaders 속성에 대한 get 접근자가 호출됨
    {
        From = "user@example.com",
        Date = DateTimeOffset.UtcNow  // Date 속성에 대한 set 접근자가 호출됨
    }
};