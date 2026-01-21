// MoveNext() 메서드의 간략화 버전

public bool MoveNext()
{
    try
    {
        switch (state)
        {
            // 메서드 내에서 올바른 위치로 점프하기 위한 점프 테이블
        }
        // yield return으로 값을 반환하기 위한 코드
    }
    fault  // 예외 발생 시 수행할 코드
    {
        Dispose();  // 예외 발생 시 정리를 위한 코드
    }
}