using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());//количество дисциплин
        HashSet<string> allStudents = null;//все студенты
        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());//количество фамилий в дисциплине
            HashSet<string> currentStudents = new HashSet<string>();//студенты по данной дисциплине
            for (int j = 0; j < m; j++)
            {
                currentStudents.Add(Console.ReadLine());
            }
            //Если первая дисциплина
            if (i == 0)
            {
                allStudents = currentStudents;
            }
            else // Пересекаем множество со всеми студентами
            {
                allStudents.IntersectWith(currentStudents);
            }
        }
        Console.WriteLine(allStudents.Count);
    }
}