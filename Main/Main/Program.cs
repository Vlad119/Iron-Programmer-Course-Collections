using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    //задача на определение списка клиентов в окнах и время работы окон
    {
        string[] split = Console.ReadLine().Split(' ');
        int clientsCount = Convert.ToInt32(split[0]);
        int windowCount = Convert.ToInt32(split[1]);
        Queue<string> queue = new Queue<string>();
        for (int i = 0; i < clientsCount; i++)
        {
            queue.Enqueue(Console.ReadLine());
        }
        // Массив для хранения времени освобождения каждой кассы
        int[] freeTime = new int[windowCount];
        // Список списков для хранения клиентов, обслуженных каждой кассой
        List<string>[] servedClients = new List<string>[windowCount];
        for (int i = 0; i < windowCount; i++)
        {
            servedClients[i] = new List<string>();
        }
        // Распределяем клиентов по кассам
        while (queue.Count > 0)
        {
            // Находим кассу с минимальным временем освобождения
            int minIndex = 0;
            for (int i = 1; i < windowCount; i++)
            {
                if (freeTime[i] < freeTime[minIndex])
                {
                    minIndex = i;
                }
            }
            // Берем следующего клиента из очереди
            string clientInfo = queue.Dequeue();
            string[] clientData = clientInfo.Split(' ');
            string clientName = clientData[0];
            int serviceTime = Convert.ToInt32(clientData[1]);
            // Добавляем клиента к этой кассе
            servedClients[minIndex].Add(clientName);
            // Обновляем время освобождения кассы
            freeTime[minIndex] += serviceTime;
        }
        // Выводим результат
        for (int i = 0; i < windowCount; i++)
        {
            if (servedClients[i].Count > 0)
            {
                Console.WriteLine(freeTime[i] + " " + string.Join(" ", servedClients[i]));
            }
            else
            {
                Console.WriteLine("0 Касса свободна");
            }
        }
    }
}
