using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //приложение ищет "день сбора"
        int friendsCount = int.Parse(Console.ReadLine());
        Dictionary<string, int> meet = new Dictionary<string, int>()
       {
            {"пн", 0 },
            {"вт", 0 },
            {"ср", 0 },
            {"чт", 0 },
            {"пт", 0 },
            {"сб", 0 },
            {"вс", 0 }
        };
        for (int i = 0; i < friendsCount; i++)
        {
            string[] days = Console.ReadLine().Split();
            foreach (string day in days)
            {
                meet[day]++; // у выбранного ключа, увеличиваем счётчик 
            }
        }
        foreach (var day in meet)
        {
            if (day.Value != 0) Console.WriteLine(day.Key + " " + day.Value);
        }
    }
}