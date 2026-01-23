// customer를 여러 패턴을 이용하여 매칭

static void Greet(Customer customer)
{
    string greeting = customer switch
    {
        { Address: { Country: "UK" } } =>  // 국가명이 UK와 매칭
            "Welcome, customer from the United Kingdom!",
        { Address: { Country: "USA" } } =>  // 국가명이 USA와 매칭
            "Welcome, customer from the USA!",
        { Address: { Country: string country } } =>  // 국가명은 고려하지 않고 국가명이 존재하는지만 확인
            $"Welcome, customer from {country}!",
        { Address: { } } =>  // 어떤 address든 매칭
            "Welcome, customer whose address has no country!",
        { } =>  // 어떤 customer든 매칭(address가 null이어도 무방)
            "Welcome, customer of an unknown address!",
        _ =>  // 무엇이든 매칭(customer가 null이어도 무방)
            "Welcome, nulless my old friend!" 
    };
    Console.WriteLine(greeting);
}