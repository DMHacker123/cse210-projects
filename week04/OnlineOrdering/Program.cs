using System;
using System.Collections.Generic;

class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }
}

class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return street + "\n" + city + ", " + state + "\n" + country;
    }
}

class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }

    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }
}

class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product p in products)
        {
            total += p.GetTotalCost();
        }

        // Add shipping cost
        if (customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product p in products)
        {
            label += p.GetName() + " (ID: " + p.GetProductId() + ")\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return customer.GetName() + "\n" + customer.GetAddress().GetFullAddress();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // First Order
        Address addr1 = new Address("123 Main St", "Miami", "FL", "USA");
        Customer cust1 = new Customer("Alice Smith", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("T-Shirt", "TS001", 10.0, 2));
        order1.AddProduct(new Product("Notebook", "NB002", 5.0, 3));

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        // Second Order
        Address addr2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Bob Johnson", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Pen Set", "PN003", 3.0, 4));
        order2.AddProduct(new Product("Backpack", "BP004", 20.0, 1));

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}
