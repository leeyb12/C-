// 바이트 단위의 비동기 작업을 효율적으로 지원하기 위한 스트림 클래스 구현

public sealed class ByteStream : IDisposable
{
    private readonly Stream stream;
    private readonly byte[] buffer;
    private int position;  // 다음번에 반환할 버퍼 인덱스
    private int bufferedBytes;  // 버퍼로 읽어온 데이터의 바이트 수

    public ByteStream(Stream stream)
    {
        this.stream = stream;
        buffer = new byte[1024 * 8];  // 8K 버퍼는 거의 대기할 필요가 없다는 것을 의미함
    } 

    public async ValueTask<byte?> ReadByteAsync()
    {
        if (position == bufferedBytes)  // 필요시 버퍼를 다시 채움
        {
            position = 0;
            bufferedBytes = await
                stream.ReadAsync(buffer, o, buffer.Length)  // 하부 Stream에서 비동기적으로 데이터를 읽어옴
                       .ConfigureAwait(false);  // Context를 무시하도록 대기 작업을 구성
            if (bufferedBytes == 0)
            {
                return null;  // 스트림의 끝을 나타냄
            }
        }
        return buffer[position++];  // 버퍼에서 다음 바이트를 반환
    }

    public void Dispose()
    {
        stream.Dispose();
    }
}
...
// 사용 예
using (var stream = new ByteStream(File.OpenRead("file.dat")))
{
    while ((nextByte = await stream.ReadByteAsync()).HasValue)
    {
        ConsumeByte(nextByte.Value);  // 가져온 바이트를 사용
    }
}