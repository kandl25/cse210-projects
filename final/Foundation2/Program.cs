using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Stephen Smith", address1);
        Customer customer2 = new Customer("George Lucas", address2);

        Product product1 = new Product("Laptop", "P001", 999.99f, 1);
        Product product2 = new Product("Mouse", "P002", 19.99f, 2);
        Product product3 = new Product("Keyboard", "P003", 49.99f, 1);
        Product product4 = new Product("Monitor", "P004", 199.99f, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: {order.CalculateTotalCost()}\n");
        }
    }
}