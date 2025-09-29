using System;
using System.Collections.Generic;

interface IProduct
{
    string Name { get; }
    decimal Price { get; }
}

class BookProduct : IProduct
{
    public string Name { get; }
    public decimal Price { get; }

    public BookProduct(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class ElectronicProduct : IProduct
{
    public string Name { get; }
    public decimal Price { get; }

    public ElectronicProduct(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class ShoppingCart
{
    private List<IProduct> products = new List<IProduct>();

    public void AddProduct(IProduct product) => products.Add(product);

    public decimal GetTotalPrice()
    {
        decimal sum = 0;
        foreach (var product in products)
            sum += product.Price;
        return sum;
    }
}

class Program
{
    static void Main()
    {
        var cart = new ShoppingCart();
        cart.AddProduct(new BookProduct("C# in Depth", 40));
        cart.AddProduct(new ElectronicProduct("Headphones", 80));

        Console.WriteLine($"Total price: {cart.GetTotalPrice()}");
    }
}
