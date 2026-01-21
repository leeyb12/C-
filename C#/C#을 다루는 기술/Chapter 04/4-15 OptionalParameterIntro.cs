// 선택적 매개변수를 가진 메서드 호출

static void Method(int x, int y = 5, int z = 10)  // 하나는 필수 매개변수, 둘은 선택적 매개변수
{
    Console.WriteLine("x={0}; y={1}; z={2}", x, y, z);  // 매개변숫값을 출력
}

Method(1, 2, 3);  // x=1, y=2, z=3
Method(x: 1, y: 2, z: 3);  // x=1, y=2, z=3
Method(z: 3. y: 2, x: 1);  // x=1, y=2, z=3
Method(1, 2);  // x=1. y=2, z=10
Method(1, y: 2);  // x=1, y=2. z=10
Method(1, z: 3);  // x=1, y=5, z=3
Method(1);  // x=1, y=5, z=10
Method(x: 1);  // x=1, y=5, z=10