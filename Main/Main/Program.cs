using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Считываем количество учеников
        int n = int.Parse(Console.ReadLine());
        // Создаем множества для уникальных и повторяющихся фамилий
        HashSet<string> unique = new HashSet<string>();
        HashSet<string> duplicates = new HashSet<string>();
        // Считываем фамилии
        List<string> surnames = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string surname = Console.ReadLine();
            surnames.Add(surname);
            if (unique.Contains(surname))
            {
                duplicates.Add(surname); // Фамилия уже встречалась
            }
            else
            {
                unique.Add(surname); // Добавляем новую фамилию
            }
        }
        // Подсчитываем количество повторений
        int count = 0;
        foreach (var surname in surnames)
        {
            if (duplicates.Contains(surname))
            {
                count++; // Учитываем каждое повторение
            }
        }
        // Выводим результат
        Console.WriteLine(count);
    }
}