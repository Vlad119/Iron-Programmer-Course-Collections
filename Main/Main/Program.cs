using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        Dictionary<string, int> tasks = new Dictionary<string, int>();
        for (int i = 0; i < count; i++)
        {
            string[] people = Console.ReadLine().Split();
            string name = people[0];
            int solved = int.Parse(people[1]);
            tasks.Add(name, solved);
        }
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] people = Console.ReadLine().Split();
            string name = people[0];
            int solved = int.Parse(people[1]);
            if (tasks.ContainsKey(name))
            {
                tasks[name] += solved;
            }
            else
            {
                tasks.Add(name, solved);
            }
        }
        foreach (var t in tasks)
        {
            Console.WriteLine($"Студент {t.Key} решил(а) {t.Value} задач");
        }
    }
}