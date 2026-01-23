// 안전한 역참조를 위해 null 조건 연산자 사용

Console.WriteLine(customer.Address?.Country ?? "(Address unknown)");