using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Считываем количество дисциплин
        int n = int.Parse(Console.ReadLine());
        HashSet<string> allStudents = null; // Множество для хранения общих учеников
        for (int i = 0; i < n; i++)
        {
            // Считываем количество фамилий в текущей дисциплине
            int m = int.Parse(Console.ReadLine());
            HashSet<string> currentStudents = new HashSet<string>();
            for (int j = 0; j < m; j++)
            {
                currentStudents.Add(Console.ReadLine()); // Добавляем фамилии в текущее множество
            }
            // Если это первая дисциплина, инициализируем allStudents
            if (i == 0)
            {
                allStudents = new HashSet<string>(currentStudents);
            }
            else
            {
                // Пересекаем текущее множество с allStudents
                allStudents.IntersectWith(currentStudents);
            }
        }
        // Выводим результат
        Console.WriteLine(allStudents.Count);
    }
}