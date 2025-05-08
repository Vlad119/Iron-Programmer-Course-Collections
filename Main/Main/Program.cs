using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        string target = Console.ReadLine();
        char symbol = char.Parse(Console.ReadLine());
        string result = string.Join(", ", IndexOfAll(target, symbol));
        Console.WriteLine(result);
    }

    static List<int> IndexOfAll(string target, char symbol)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < target.Length; i++)
        {
            if (target[i] == symbol)
            {
                result.Add(i);
            }
        }
        return result;
    }
}
