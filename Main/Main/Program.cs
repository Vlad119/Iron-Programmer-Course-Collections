using System.Collections.Generic;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> cupNames = new List<string>(); //кружки изначально
        List<string> boughtCupNames = new List<string>();//купленные кружки
        int currentCupCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < currentCupCount; i++)
        {
            cupNames.Add(Console.ReadLine());
        }
        int crashedCupCount = int.Parse(Console.ReadLine());//разбитые
        int bouhgtCupCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < bouhgtCupCount; i++)
        {
            boughtCupNames.Add(Console.ReadLine());
        }
        int remainsCupCount = cupNames.Count - crashedCupCount;//оставшиеся кружки
        for (int i = 0; i < remainsCupCount; i++)
        {
            Console.WriteLine(cupNames[i]);
        }
        for (int i = 0; i < boughtCupNames.Count; i++)
        {
            Console.WriteLine(boughtCupNames[i]);
        }
        Console.WriteLine(currentCupCount <= remainsCupCount + bouhgtCupCount ? "Радостно!" : "Грустно!");
    }
}
