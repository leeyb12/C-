// 비동기 숫자 시퀀스 순회

var cts = new CancellationTokenSource();
await foreach (int item in RangeAsync(10, 3, cts.Token))
{
    Console.WriteLine(item);
}