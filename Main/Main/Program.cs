using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> plates = new List<string>();
        for (int i = 0; i < n; i++)
        {
            plates.Add(Console.ReadLine());
        }
        int k = int.Parse(Console.ReadLine());
        plates.Reverse();
        Console.WriteLine("Все тарелки в одной стопке:");
        foreach (var plate in plates)
        {
            Console.WriteLine(plate);
        }
        Console.WriteLine("Оставшиеся тарелки в первоначальной стопке:");
        if (n <= k)
        {
            foreach (var plate in plates)
            {
                Console.WriteLine(plate);
            }
        }
        else
        {
            List<string> remainingPlates = plates.GetRange(plates.Count - k, k);
            foreach (var plate in remainingPlates)
            {
                Console.WriteLine(plate);
            }
            List<string> remainingStack = plates.GetRange(0, plates.Count - k);
            int startIndex = 0;
            while (startIndex < remainingStack.Count)
            {
                Console.WriteLine("Новая стопка:");
                List<string> newStack = remainingStack.GetRange(startIndex, Math.Min(k, remainingStack.Count - startIndex));
                newStack.Reverse();
                foreach (var plate in newStack)
                {
                    Console.WriteLine(plate);
                }
                startIndex += k;
            }
        }
    }
}