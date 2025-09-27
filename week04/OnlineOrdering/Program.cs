using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Wireless Mouse", 101, 25.50, 2);
        Product product2 = new Product("USB-C Charger", 102, 19.99, 1);
        Product product3 = new Product("Bluetooth Headphones", 201, 59.991, 1);
        Product product4 = new Product("Laptop Sleeve", 202, 29.99, 2);

        Address address1 = new Address("123 Main Street", "Los Angeles", "California", "United States");
        Customer customer1 = new Customer("Paulina", address1);
        Address address2 = new Address("789 Queen Street", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Ariadna", address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        string one = $"{order1.GetPackingLabel()}\n{order1.GetShippingLabel()}\nTotal Price: ${order1.GetTotalPrice()}\n";
        string two = $"{order2.GetPackingLabel()}\n{order2.GetShippingLabel()}\nTotal Price: ${order2.GetTotalPrice()}\n";

        Console.WriteLine($"{one}\n{two}");
    }
}


class Address
{
    private string Street;
    private string City;
    private string State;
    private string Country;

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool InUsa()
    {
        if (Country.Contains("United"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetFullAddress()
    {
        string fullAddress = $"Street: {Street}\nCity: {City}\nState: {State}\nCountry: {Country} ";
        return fullAddress;
    }
}

class Customer
{
    private string Name;
    private Address Address;


    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }
    public bool LivesInUSA()
    {
        if (Address.InUsa())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetName()
    {
        return Name;
    }
    public Address GetAddress()
    {
        return Address;
    }
}
class Product
{
    private string Name;
    private int ProductId;
    private double PricePerUnit;
    private int Quantity;


    public Product(string name, int productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = price;
        Quantity = quantity;
    }

    public string GetName()
    {
        return Name;
    }
    public int GetId()
    {
        return ProductId;
    }
    public double GetTotalCost()

    {
        double total = PricePerUnit * Quantity;
        return total;
    }
    public void GetProductInfo()
    {
        Console.WriteLine("Product details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Id: {ProductId}");
        Console.WriteLine($"Price: {PricePerUnit}");
        Console.WriteLine($"Quantity: {Quantity}");
    }
}

class Order
{
    private List<Product> Products = new List<Product>();
    private Customer Customer;


    public Order(Customer customer)
    {
        Customer = customer;
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product p in Products)
        {
            total += p.GetTotalCost();
        }
        if (Customer.LivesInUSA())
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
        string label = "PACKING LABEL:\n";
        foreach (Product p in Products)
        {
            label += $"Product: {p.GetName()}\n";
            label += $"Id: {p.GetId()}\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        string label = $"SHIPPING LABEL:\n";
        label += $"Customer Name: {Customer.GetName()}\n";
        label += $"Address \n{Customer.GetAddress().GetFullAddress()}\n";
        return label;
    }
}