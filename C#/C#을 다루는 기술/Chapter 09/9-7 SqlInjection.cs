// 헉! 헉! 이런 코드를 절대 사용하지 말 것!

var tag = Console.WriteLine();  // 사용자로부터 값을 입력
using (var conn = new SqlConnection(connectionString))
{
    conn.Open();
    string sql = 

        // 사용자 정보를 기반으로 SQL 구문을 동적으로 생성
        $@"SELECT Description FROM Entries
           WHERE Tag='{tag}' AND UserId={userId}";
    using (var command = new SqlCommand(sql, conn))
    {
        using (var reader = command.ExecuteReader())  // 신뢰할 수 없는 SQL 수행
        {
            ...  // 반환된 결과 사용
        }
    }
}