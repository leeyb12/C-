// dynamic 타입의 대상에 대해 확장 메서드를 수행하려고 시도

dynamic source = new List<dynamic>
{
    5,
    2.75,
    TimeSpan.FromSeconds(45)
};
bool result = source.Any();