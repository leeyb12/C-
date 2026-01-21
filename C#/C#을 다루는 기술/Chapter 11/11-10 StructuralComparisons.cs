// 대소문자를 구분하지 않는 구조적 비교

static void Main()
{
    // 가지고 있는 값을 변수 이름으로 사용한 다소 특이한 변수
    var Ab = ("A", "b");
    var aB = ("a", "B");
    var aa = ("a", "a");
    var ba = ("b", "a");

    // 흥미로운 비교 수행
    Compare(Ab, aB);
    Compare(aB, aa);
    Compare(aB, ba);
}

static void Compare<T>(T x, T y)
    where T : IStructuralEquatable, IStructuralComparable
{
    // 대소문자를 구분하지 않는 비교기를 이용하여 순차성 및 동일성 연산 수행
    var comparison = x.CompareTo(
        y, StringComparer.OrdinalIgnoreCase);
    var equal = x.Equal(
        y, StringComparer.OrdinalIgnoreCase);

    Console.WriteLine(
        $"{x} and {y} - comparison: {comparison}; equal: {equal}");
}