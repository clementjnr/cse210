using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main St",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(
            new Product("Laptop", "P100", 800, 1)
        );

        order1.AddProduct(
            new Product("Mouse", "P101", 25, 2)
        );

        Address address2 = new Address(
            "15 Victoria Road",
            "Lagos",
            "Lagos",
            "Nigeria"
        );

        Customer customer2 = new Customer(
            "Clement Johnson",
            address2
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(
            new Product("Phone", "P200", 500, 1)
        );

        order2.AddProduct(
            new Product("Charger", "P201", 30, 2)
        );

        Console.WriteLine("===== ORDER 1 =====");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("\n============================\n");

        Console.WriteLine("===== ORDER 2 =====");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order2.GetTotalCost()}");
    }
}

