// Enumerable.Count를 두 가지 방법으로 호출

using System.Collections.Generic;
using static System.Linq.Enumerable;

...
IEnumerable<string> strings = new[] { "a", "b", "c" };

int valid = strings.Count();  // 유효함: Count() 메서드를 인스턴스 메서드처럼 호출
int invalid = Count(strings);  // 유효하지 않음: 일반적인 정적 메서드처럼 확장 메서드를 임포트하지 않았음