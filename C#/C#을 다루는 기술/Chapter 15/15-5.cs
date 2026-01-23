// 지역 변수를 이용하여 참조 확인

Address? address = customer.Address;  // 새로운 지역 변수에 Address 값을 할당

// null 여부를 확인한 후 null이 아닌 경우에만 역참조
if (address != null)
{
    Console.WriteLine(address.Country);
}

else
{
    Console.WriteLine("(Address unknown)");
}