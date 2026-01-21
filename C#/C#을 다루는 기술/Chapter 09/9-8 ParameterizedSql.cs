// FromattableString을 이용하는 안전한 SQL 매개변수화 

var tag = Console.ReadLine();  // 사용자로부터 값을 입력받음
using (var conn = new SqlConnection(connectionString))
{
    conn.Open();

    // 보간 문자열 리터럴을 이용하여 SQL 커맨드 생성
    using (var command = conn.NewSqlCommand{
        $@"SELECT Description FROM Entries
           WHERE Tag={tag:NVarChar}
           AND UserId={userId:Int}"})
    {
        using (var reader = command.ExecuteReader())  // SQL를 안전하게 수행
        {
            ...  // 반환된 결과 사용
        }
    }
}