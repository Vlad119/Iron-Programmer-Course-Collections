using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        // Считываем количество курсов, которые уже проходит/прошел ученик
        int n = int.Parse(Console.ReadLine());
        HashSet<string> completedCourses = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            completedCourses.Add(Console.ReadLine());
        }
        // Считываем количество курсов, которые ученик наметил пройти
        int m = int.Parse(Console.ReadLine());
        List<string> plannedCourses = new List<string>();
        for (int i = 0; i < m; i++)
        {
            plannedCourses.Add(Console.ReadLine());
        }
        // Проверяем каждый запланированный курс
        foreach (string course in plannedCourses)
        {
            Console.WriteLine(completedCourses.Contains(course) ? "YES" : "NO");
        }
    }
}
