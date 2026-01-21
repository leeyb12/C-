// 명시적 인터페이스 구현

List<int> list1 = new List<int>();
Console.WriteLine(list1.IsFixedSize);  // 컴파일 오류

IList list2 = list1;
Console.WriteLine(list2.IsFixedSize);  // 성공. False 출력

dynamic list3 = list1;
Console.WriteLine(list3.IsFixedSize);  // 런타임 오류