var order = new order
{
    OrderId = "xyz",
    Customer = new Customer { Name="Jon", Address="UK" },
    Items = 
    {
        new OrderItem { ItemId = "abcd123", Quantity = 1 },
        new OrderItem { ItemId = "fghi456", Quantity = 2 }
    }
};