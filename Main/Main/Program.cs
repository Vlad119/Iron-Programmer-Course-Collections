using System;
using System.Collections.Generic;

class Program
{
    static void Main()
        //приложение находит страну по городу
    {
        int countryCount = int.Parse(Console.ReadLine());
        Dictionary<string, string> cities = new Dictionary<string, string>();
        for (int i = 0; i < countryCount; i++)
        {
            string[] split = Console.ReadLine().Split();
            for (int j = 1; j < split.Length; j++)
            {
                cities.Add(split[j], split[0]);
            }
        }
        int n = int.Parse(Console.ReadLine());
        string[] split2 = new string[n];
        for (int i = 0; i < n; i++)
        {
            split2[i] = Console.ReadLine();
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(cities[split2[i]]);
        }
    }
}