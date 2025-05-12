using System.Collections.Generic;
using System;

internal class Program
{

    static void Main(string[] args)// задача на простые делители числа
    {
        int num = Convert.ToInt32(Console.ReadLine());
        List<int> divisors = GetPrimeDivisors(num);
        Console.Write(string.Join(" ", divisors));
    }

    static List<int> GetPrimeDivisors(int n)
    {
        int count = 0;
        List<int> result = new List<int>();
        while (n > 1)
        {
            for (int i = 2; i < 10; i++)
            {
                count = 0;
                if (n % i == 0)
                {
                    result.Add(i);
                    n /= i;
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                result.Add(n);
                break;
            }
        }
        return result;
    }
}
