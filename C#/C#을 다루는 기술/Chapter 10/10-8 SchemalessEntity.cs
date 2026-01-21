// SchemalessEntity를 초기화하는 두 가지 방법

SchemalessEntity parent = new SchemalessEntity { key = "parent-key" };
SchemalessEntity child1 = new SchemalessEntity  // 컬렉션 초기화자를 이용하여 데이터 속성 설정
{
    { "name", "Jon Skeet" },
    { "location", "Reading, UK" }
};

// 키 속성은 분리하여 설정
child1.Key = "child-key";
child1.ParentKey = parent.Key;

SchemalessEntity child2 = new SchemalessEntity
{
    // 객체 초기화자를 이용하여 키 속성 설정
    Key = "child-key",
    ParentKey = parent.Key,

    // 인덱서를 이용하여 데이터 속성 설정
    ["name"] = "Jon Skeet",
    ["location"] = "Reading, UK"
};