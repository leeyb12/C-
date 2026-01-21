// 디렉터리를 초기화하는 두 가지 방법

var collectionInitializer = new Dictionary<string, int>  // C# 3부터 제공되는 일반적인 컬렉션 초기화자 사용
{
    { "A", 20 },
    { "B", 30 }, 
    { "c", 40 }
};

var objectInitializer = new Dictionary<string, int>  // C# 6부터 제공되는 객체 초기화자 내의 인덱서 사용
{
    ["A"] = 20,
    ["B"] = 30, 
    ["C"] = 40
};