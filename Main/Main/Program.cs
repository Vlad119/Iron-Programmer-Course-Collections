using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> allCources = new List<string>();
        List<string> passedCources = new List<string>();
        int totalCourseCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < totalCourseCount; i++)
        {
            allCources.Add(Console.ReadLine());
        }
        int passedCourseCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < passedCourseCount; i++)
        {
            passedCources.Add(Console.ReadLine());
        }
        if (allCources.Count == passedCources.Count)
            Console.WriteLine("Начните новый курс Иосифа Дзеранова! И станьте еще на шаг ближе к профессии разработчик!");
        else
        {
            for (int i = 0; i < passedCourseCount; i++)
            {
                allCources.Remove(passedCources[i]);
            }
            foreach (var cource in allCources)
            {
                Console.WriteLine(cource);
            }
        }
    }
}
