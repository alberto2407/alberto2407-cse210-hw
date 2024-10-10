using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressUSA = new Address("123 Main St", "Springfield", "IL", "USA");
        Address addressNonUSA = new Address("C/Paris, 6", "Sabadell", "Barcelona", "España");

        Customer customer1 = new Customer("Austin Chritensen", addressUSA);
        Customer customer2 = new Customer("Alberto Flores", addressNonUSA);

        Product product1 = new Product("MacBook", "L001", (double)1200.50m, 1);
        Product product2 = new Product("Mouse", "M002", (double)25.99m, 2);
        Product product3 = new Product("Keyboard", "K003", (double)49.99m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order2.GetTotalCost()}");
    }
}