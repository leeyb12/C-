// C# 7.3에서의 새로운 제약 조건

enum SampleEnum {}
static void EnumMethod<T>() where T : struct, Enum {}
static void DelegateMethod<T>() where T : Delegate {}
static void UnmanagedMethod<T>() where T : unmanaged {}
...
EnumMethod<SampleEnum>();  // 유효함: enum 값 타입
EnumMethod<Enum>();  // 유효하지 않음: struct 제약 조건 위배

// (불행히도) 모두 유효함
DelegateMethod<Action>();
DelegateMethod<Delegate>();
DelegateMethod<MulticastDelegate>();

UnmanagedMethod<int>();  // 유효함: System.Int32는 unmanaged 타입
UnmanagedMethod<string>();  // 유효함: System.String은 managed 타입