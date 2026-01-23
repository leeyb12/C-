// Address 속성이 null이 될 수 있도록 Customer 클래스 변경

public class Customer
{
    public string Name { get; set; }
    public Address? Address { get; set; }  // 주소는 이제 필수 정보가 아님

    public Customer(string name) =>  // 생성자에서 Address 타입의 매개변수를 제거
        Name = name;
}