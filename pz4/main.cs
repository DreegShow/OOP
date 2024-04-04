using System;
using System.Collections.Generic;

record Product(string Name, decimal OriginalPrice, decimal DiscountedPrice);

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        // Ввід даних товарів з консолі
        Console.WriteLine("дані товарів (назва, ціна) і потом =");
        string input;
        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            string[] data = input.Split(',');
            if (data.Length == 2 && decimal.TryParse(data[1], out decimal price))
            {
                products.Add(new Product(data[0].Trim(), price, price));
            }
            else
            {
                Console.WriteLine("невірно");
            }
        }

        decimal total = 0;
        foreach (var product in products)
        {
            total += product.OriginalPrice;
        }

        if (total > 500)
        {
            Console.WriteLine("\n знижка 5%!");
            for (int i = 0; i < products.Count; i++)
            {
                products[i] = products[i] with { DiscountedPrice = products[i].OriginalPrice * 0.95m };
            }
        }

        Console.WriteLine("\n Список товарів:");
        foreach (var product in products)
        {
            Console.WriteLine($"- {product.Name}, орігінальна ціна: {product.OriginalPrice} грн, " +
                              $"ціна зі знижкой: {product.DiscountedPrice} грн");
        }

        Console.WriteLine($"Загальна сума: {total} грн");
    }
}
