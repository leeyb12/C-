// 버전 정보와 함께 고정 길이 버퍼를 포함하는 구조체의 예

unsafe struct VersionedData
{
    public int Major;
    public int Minor;
    public fixed byte Data[16];
}

unsafe static void Main()
{
    VersionedData versioned = new VersionedData();
    versioned.Major = 2;
    versioned.Minor = 1;
    versioned.Data[10] = 20;
}