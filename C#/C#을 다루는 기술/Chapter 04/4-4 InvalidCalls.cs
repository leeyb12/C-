// dynamic을 사용했을 때 컴파일 오류가 발생하는 예

dynamic d = new object();  
int invalid1 = "text".Substring(0, 1, 2, d);  // 네 개의 매개변수를 취하는 String.Substring 메서드는 존재하지 않는다.
bool invalid2 = string.Equals<int>("foo", d);  // 제네릭 타입의 String.Equals 메서드는 존재하지 않는다.
string invalid3 = new string(d, "broken");  // 두 개의 인수를 취하는 string 타입의 생성자 중에 두 번째 인수로 string을 받는 생성자는 없다.
char invalid4 = "text"[d, d];  // string에는 두 개의 인수를 취하는 인덱서가 없다.
