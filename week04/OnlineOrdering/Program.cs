using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}

//Online Ordering Program
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
        return true;
    }
    public string GetFullAddress()
    {
        return "";
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
        return true;
    }
    public string GetName()
    {
        return "";
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
    public double GetTotalCost()

    {
        return 0;
    }
    public void GetProductInfo()
    {

    }
}

class Order
{
    private List<Product> Products = new List<Product>();
    private Customer Customer;


    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }
    public void AddProduct(Product product)
    {

    }
    public void GetTotalPrice()
    {

    }
    public string GetPackingLabel()
    {
        return "";
    }
    public string GetShippingLabel()
    {
        return "";
    }
}