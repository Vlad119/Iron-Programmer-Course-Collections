using System;
using System.Collections.Generic;

class Program
{
    static void Main()
        //программа ищет синонимы
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> synonyms = new Dictionary<string, string>();
        for (int i = 0; i < n; i++)
        {
            string[] pair = Console.ReadLine().Split();
            synonyms.Add(pair[0], pair[1]);
            synonyms.Add(pair[1], pair[0]);
        }
        string word = Console.ReadLine();
        Console.WriteLine(synonyms[word]);
    }
}