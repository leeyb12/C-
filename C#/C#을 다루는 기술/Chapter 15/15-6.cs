// 속성에 반복 접근하여 참조 확인

if (customer.Address != null)
{
    Console.WriteLine(customer.Address.Country);
}
else
{
    Console.WriteLine("(Address unknown)");
}