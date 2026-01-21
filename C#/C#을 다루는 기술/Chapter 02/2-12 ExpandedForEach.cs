// foreach 루프의 변형

IEnumerable<int> enumerable = CreateSimpleIterator();  // 이터레이터 메서드를 호출한다.
using (IEnumerator<int> enumerator = 
    enumerable.GetEnumerator())  // IEnumerable<T>를 이용하여 IEnumerator<T>를 가져온다.
{
    while (enumerator.MoveNext())  // 값이 있다면 다음 위치로 이동한다.
    {
        int value = enumerator.Current;  // 현재 위치의 값을 가져온다.
        Console.WriteLine(value);
    }
}