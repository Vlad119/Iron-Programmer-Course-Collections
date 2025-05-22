using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> cities = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            cities.Add(Console.ReadLine());
        }
        string newCity = Console.ReadLine();
        Console.WriteLine(cities.Contains(newCity) ? "EXIST" : "OK");
    }
}
