using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    // задача про пакеты на портах коммутатора
    {
        Queue<string> recievedPackages = new Queue<string>();
        int packageCount8 = int.Parse(Console.ReadLine());//8 порт
        for (int i = 0; i < packageCount8; i++)
        {
            recievedPackages.Enqueue(Console.ReadLine());
        }
        int packageCount9 = int.Parse(Console.ReadLine());// 9 порт
        for (int i = 0; i < packageCount9; i++)
        {
            recievedPackages.Enqueue(Console.ReadLine());
        }
        int portNumber = int.Parse(Console.ReadLine());//номер порта для проверки
        Queue<string> neededPackages = new Queue<string>();//очередь с нужным портом
        if (portNumber > 5) //6 7 порт
        {
            foreach (var item in recievedPackages)
            {
                if (item.Contains("NULL"))
                {
                    neededPackages.Enqueue(item);
                }
            }
        }
        else
        if (portNumber < 4) //1 2 3 порт
        {
            foreach (var item in recievedPackages)
            {
                if (item.Contains("VL10"))
                {
                    neededPackages.Enqueue(item);
                }
            }
        }
        else//4 5 порт
        {
            foreach (var item in recievedPackages)
            {
                if (item.Contains("VL12"))
                {
                    neededPackages.Enqueue(item);
                }
            }
        }
        Console.WriteLine($"На порт {portNumber} прилетело {neededPackages.Count} пакетов:");
        foreach (var item in neededPackages)
        {
            Console.WriteLine(item);
        }
    }
}
