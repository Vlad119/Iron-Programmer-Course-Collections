using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var set1 = new HashSet<string>();
        var set2 = new HashSet<string>();
        for (var i = 0; i < n; i++)
        {
            var s = Console.ReadLine();
            if (set1.Add(s)) continue;
            set2.Add(s);
        }
        set1.ExceptWith(set2);
        Console.WriteLine(n - set1.Count);
    }
}