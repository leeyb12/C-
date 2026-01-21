// 객체 초기화 구문과 컬렉션 초기화 구문 없이 Order 객체를 생성하는 방법

// Customer 생성
var customer = new Customer();
customer.Name = "Jon";
customer.Address = "UK";

// 첫 번째 OrderItem 생성
var item1 = new OrderItem();
item1.ItemId = "abcd123";
item1.Quantity = 1;

// 두 번째 OrderItem 생성
var item2 = new OrderItem();
item2.ItemId = "fghi456";
item2.Quantity = 2;

// Order 생성
var order = new Order();
order.OrderId = "xyz";
order.Customer = customer;
order.Items.Add(item1);
order.Items.Add(item2);
