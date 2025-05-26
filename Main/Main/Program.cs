using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var masters = new Dictionary<string, HashSet<char>>();
        for (int i = 0; i < n; i++)
        {
            string[] split = Console.ReadLine().Split();
            string name = split[0]; 
            HashSet<char> categories = new HashSet<char>();
            for (int j = 1; j < split.Length; j++)
            {
                char category = char.ToUpper(split[j][0]); 
                categories.Add(category);
            }
            masters[name] = categories;
        }
        int m = int.Parse(Console.ReadLine());
        List<string> results = new List<string>();
        for (int i = 0; i < m; i++)
        {
            string[] split = Console.ReadLine().Split();
            if (split.Length < 2)
            {
                results.Add("NO");
                continue;
            }
            char category = char.ToUpper(split[0][0]); 
            string masterName = split[1]; 
            if (masters.ContainsKey(masterName) && masters[masterName].Contains(category))
            {
                results.Add("YES");
            }
            else
            {
                results.Add("NO");
            }
        }
        Console.WriteLine(string.Join("\n", results));
    }
}