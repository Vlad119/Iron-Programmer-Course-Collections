using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Чтение входных данных
        string[] childrenInput = Console.ReadLine().Split();
        string[] platesInput = Console.ReadLine().Split();
        // Инициализация очереди детей и стека тарелок
        Queue<int> children = new Queue<int>();
        Stack<int> plates = new Stack<int>();
        // Заполняем очередь детей
        foreach (var child in childrenInput)
            children.Enqueue(int.Parse(child));
        // Заполняем стек тарелок (сверху вниз)
        for (int i = platesInput.Length - 1; i >= 0; i--)
            plates.Push(int.Parse(platesInput[i]));
        // Переменная для отслеживания количества итераций без изменений
        int lastLength = children.Count;
        int iterationCount = 0;
        // Основной цикл распределения тарелок
        while (plates.Count > 0 && children.Count > 0)
        {
            int child = children.Peek(); // Смотрим первого ребенка в очереди
            if (child == plates.Peek()) // Если предпочтение совпадает с верхней тарелкой
            {
                children.Dequeue(); // Убираем ребенка из очереди
                plates.Pop();       // Убираем тарелку из стека
                iterationCount = 0; // Сбрасываем счетчик итераций
            }
            else
            {
                children.Enqueue(children.Dequeue()); // Перемещаем ребенка в конец очереди
                iterationCount++; // Увеличиваем счетчик итераций
            }
            // Если все дети прошли через очередь без изменений
            if (iterationCount >= children.Count)
                break;
        }
        // Выводим количество оставшихся детей в очереди
        Console.WriteLine(children.Count);
    }
}