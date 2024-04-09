using System;
using System.Collections.Generic;

abstract class UtilitiesPrice
{
    public abstract double CalculatePrice();
}

class FixedPrice : UtilitiesPrice
{
    private double price;

    public FixedPrice(double price)
    {
        this.price = price;
    }

    public override double CalculatePrice()
    {
        return price;
    }
}

class ConsumedAmountPrice : UtilitiesPrice
{
    private double rate;
    private double amount;

    public ConsumedAmountPrice(double rate, double amount)
    {
        this.rate = rate;
        this.amount = amount;
    }

    public override double CalculatePrice()
    {
        return rate * amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<UtilitiesPrice> utilities = new List<UtilitiesPrice>();

        Console.WriteLine("Дані комунальних платежів:");
        while (true)
        {
            Console.WriteLine("тип = ");
            string type = Console.ReadLine();

            if (type == "fixed")
            {
                Console.WriteLine("Введіть фіксовану ціну:");
                if (double.TryParse(Console.ReadLine(), out double price))
                {
                    utilities.Add(new FixedPrice(price));
                }
                else
                {
                    Console.WriteLine("Некоректно.");
                }
            }
            else if (type == "consumed")
            {
                Console.WriteLine("Ставка:");
                if (double.TryParse(Console.ReadLine(), out double rate))
                {
                    Console.WriteLine("Обсяг:");
                    if (double.TryParse(Console.ReadLine(), out double amount))
                    {
                        utilities.Add(new ConsumedAmountPrice(rate, amount));
                    }
                    else
                    {
                        Console.WriteLine("неправ знач");
                    }
                }
                else
                {
                    Console.WriteLine("НПерероблюй");
                }
            }
            else
            {
                Console.WriteLine("неправильний тип");
            }

            Console.WriteLine("Продовжити введення? (так або ні):");
            string cont = Console.ReadLine();
            if (cont != "так")
            {
                break;
            }
        }
        double total = 0;
        foreach (var utility in utilities)
        {
            total += utility.CalculatePrice();
        }

        Console.WriteLine($"Загальна сума ком. платежів: {total}");
    }
}
