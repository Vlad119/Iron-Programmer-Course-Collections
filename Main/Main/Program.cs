using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Queue<int> player1 = new Queue<int>();
        Queue<int> player2 = new Queue<int>();
        for (int i = 0; i < input.Length; i++)
        {
            int card = int.Parse(input[i]);
            if (i % 2 == 0)
                player1.Enqueue(card);
            else
                player2.Enqueue(card);
        }
        int moves = 0;
        while (player1.Count > 0 && player2.Count > 0)
        {
            if (moves > 1000000)
            {
                Console.WriteLine("Бесконечная игра");
                return;
            }
            int card1 = player1.Dequeue();
            int card2 = player2.Dequeue();
            Console.WriteLine($"Игрок1 {card1} Игрок2 {card2}");
            bool player1Wins = false;
            if (card1 == 0 && card2 == 9)
            {
                player1Wins = true;
            }
            else if (card1 > card2)
            {
                player1Wins = true;
            }
            if (player1Wins)
            {
                player1.Enqueue(card1);
                player1.Enqueue(card2);
            }
            else
            {
                player2.Enqueue(card2);
                player2.Enqueue(card1);
            }
            moves++;
        }
        if (player1.Count > 0)
        {
            Console.WriteLine("Игрок1");
        }
        else
        {
            Console.WriteLine("Игрок2");
        }
    }
}