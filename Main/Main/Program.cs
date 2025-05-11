using System.Collections.Generic;
using System;

internal class Program
{

    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        List<int> divisors = GetDivisors(num);
        Console.Write(String.Join(", ", divisors));
    }

    static List<int> GetDivisors(int n)
    {
        List<int> result = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0) result.Add(i);
        }
        return result;
    }
}
