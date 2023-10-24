using System;

class Program
{
    static void Main(string[] args)
    {
        Address customer1Address = new Address(streetAddress: "2 Jabulani Crescent", city: "Matsapha", stateOrProvince: "Manzini", country: "Eswatini");

        Customer customer1 = new Customer(name: "Abel Kane", address: customer1Address);

        Product customer1Product1 = new Product(name: "Milky Lane", productId: "52562489235", price: 1.52, quantity: 2);

        Product customer1Product2 = new Product(name: "Diet Coke", productId: "11187455412", price: 3.52, quantity: 1);

        List<Product> customer1Products = new List<Product> { customer1Product1, customer1Product2 };

        Order customer1Order = new Order(customer: customer1, products: customer1Products);


        Address customer2Address = new Address(streetAddress: "56 Rodeo dr", city: "Beverly Hills", stateOrProvince: "California", country: "USA");

        Customer customer2 = new Customer(name: "Sakhile Mamba", address: customer2Address);

        Product customer2Product1 = new Product(name: "Pepperoni Pizza XL", productId: "2223541538", price: 2.53, quantity: 1);

        Product customer2Product2 = new Product(name: "Red Bull 440ml", productId: "11187455412", price: 2.00, quantity: 2);

        List<Product> customer2Products = new List<Product> { customer2Product1, customer2Product2 };

        Order customer2Order = new Order(customer: customer2, products: customer2Products);

        Console.Clear();

        Console.WriteLine("ORDER 1 DETAILS: ");
        Console.WriteLine();
        Console.WriteLine(customer1Order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(customer1Order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"ORDER TOTAL: {customer1Order.OrderTotal()}");
        Console.WriteLine();

        Console.WriteLine("==================================================================");

        Console.WriteLine();
        Console.WriteLine("ORDER 2 DETAILS: ");
        Console.WriteLine();
        Console.WriteLine(customer2Order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(customer2Order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"ORDER TOTAL: {customer2Order.OrderTotal()}");
        Console.WriteLine();
    }
}