using System;
using System.Collections.Generic;

class CustomList
{
    private List<string> elements;

    public CustomList()
    {
        elements = new List<string>();
    }

    public void Add(string item)
    {
        elements.Add(item);
    }

    public string Get(int index)
    {
        if (index >= 0 && index < elements.Count)
        {
            return elements[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Не вірний індекс");
        }
    }

    public void Set(int index, string newItem)
    {
        if (index >= 0 && index < elements.Count)
        {
            elements[index] = newItem;
        }
        else
        {
            throw new IndexOutOfRangeException("Індекс виходить за межі списку");
        }
    }

    public void Delete(int index)
    {
        if (index >= 0 && index < elements.Count)
        {
            elements.RemoveAt(index);
        }
        else
        {
            throw new IndexOutOfRangeException("Індекс не вірний");
        }
    }

    public int Size()
    {
        return elements.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomList myList = new CustomList();
        int idx;

        myList.Add("1string");
        myList.Add("стрінга 2");
        myList.Add("стрінг 3");
        myList.Add("123");

        Console.WriteLine("Розмір списку стрінгів: " + myList.Size());

        Console.WriteLine("Елемент за заданим індексом (1): " + myList.Get(1));

        myList.Set(1, "Оновлений 1string GG");

        Console.WriteLine("1 елемент після оновлення: " + myList.Get(1));

        myList.Delete(0);

        Console.WriteLine("Розмір списку після видалення: " + myList.Size());
    }
}

