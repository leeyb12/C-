// 단위 테스트 작성 시 null 허용 연산자 사용

public class Customer
{
    public string Name { get; }
    public Address? Address { get; }

    public Customer(string name, Address? address)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Address = address;
    }
}

public class Address
{
    public string Country { get; }

    public Address(string country)
    {
        Country = country ??
            throw new ArgumentNullException(nameof(country));
    }
}

[Test]
public void Customer_NameValidation()
{
    Address address = new Address("UK");
    Assert.Throws<ArgumentNullException>(
        () => new Customer(null!, address));  // null 불가능 매개변수에 대해 의도적으로 null 값을 전달
}