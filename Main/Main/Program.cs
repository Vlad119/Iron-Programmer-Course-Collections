using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    // программа ищет количество студентов, которые изучают только один язык
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> cSharpStudents = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            cSharpStudents.Add(Console.ReadLine());
        }
        int m = int.Parse(Console.ReadLine());
        HashSet<string> kotlinStudents = new HashSet<string>();
        for (int i = 0; i < m; i++)
        {
            kotlinStudents.Add(Console.ReadLine());
        }
        HashSet<string> onlyCSharp = new HashSet<string>(cSharpStudents);
        onlyCSharp.ExceptWith(kotlinStudents);
        HashSet<string> onlyKotlin = new HashSet<string>(kotlinStudents);
        onlyKotlin.ExceptWith(cSharpStudents);
        int result = onlyCSharp.Count + onlyKotlin.Count;
        Console.WriteLine(result == 0 ? "NO" : result + "");
    }
}