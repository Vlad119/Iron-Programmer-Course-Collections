using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    // задача про очереди в поликлинике
    {
        int patientCount = int.Parse(Console.ReadLine());
        Queue<string> patient = new Queue<string>();
        for (int i = 0; i < patientCount; i++)
        {
            patient.Enqueue(Console.ReadLine());
        }
        int windowsCount = int.Parse(Console.ReadLine());
        int index = 0;
        if (patient.Count == 0)
        {
            for (int i = 0; i < windowsCount; i++)
            {
                Console.WriteLine($"Окно {i + 1} свободно");
            }
            return;
        }
        if (windowsCount < patient.Count)
        {
            for (int i = 0; i < windowsCount; i++)
            {
                Console.WriteLine($"Клиент {patient.Peek()} --> Окно {i + 1}");
                patient.Dequeue();
            }
            foreach (var p in patient)
            {
                Console.WriteLine($"Клиент {p} остается ждать");
            }
        }
        else
        {
            for (int i = 0; i <= patient.Count; i++)
            {
                Console.WriteLine($"Клиент {patient.Peek()} --> Окно {i + 1}");
                patient.Dequeue();
                index++;
            }
            for (int i = index; i < windowsCount; i++)
            {
                Console.WriteLine($"Окно {i + 1} свободно");
            }
        }
    }
}
