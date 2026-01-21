// 확장 메서드를 선택적으로 임포트

using static System.Linq.Queryable;
...
var query = new[] { "a", "bc", "d" }.AsQueryable();  // IQueryable<string> 생성

// 델리게이트와 표현식 트리 생성
Expression<Func<string, bool>> expr =
    x => x.Length > 1;
Func<string, bool> del = x => x.Length > 1;

var valid = query.Where(expr);  // 유효함: Queryable.Where를 사용
var invalid = query.Where(del);  // 유효하지 않음: 델리게이트를 받아들일 수 있는 Where 메서드가 존재하지 않음