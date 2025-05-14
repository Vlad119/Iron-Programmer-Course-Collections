using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)//Задача Иосифа Флавия
    {
        List<int> list = new List<int>();
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i != n; i++)
        {
            list.Add(i + 1);
        }
        int position = 0;
        while (list.Count > 1)
        {
            position = (position + k - 1) % list.Count;
            list.RemoveAt(position);
        }
        Console.WriteLine(list[0]);
    }
}
