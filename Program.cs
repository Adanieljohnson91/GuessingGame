using System;
using System.Collections.Generic;

namespace GuessingGame
{
    class Program
    {
        static void AskFor(string message, string success, string failure, int sercet, int difficulty)
        {
            int count = 1;
            Console.WriteLine(message);
            string answer = Console.ReadLine();
            Int32.TryParse(answer, out int num);
            while (count < difficulty)
            {

                if (num == sercet)
                {
                    Console.WriteLine(success);
                    return;
                }
                Console.WriteLine($"You have {difficulty - count} guesses remaining");
                string howOff = num < sercet ? "Too Low" : "Too High";
                Console.WriteLine(howOff);
                Console.WriteLine(message);
                answer = Console.ReadLine();
                Int32.TryParse(answer, out num);
                count++;
            }
            string successMessage = num == sercet ? success : failure;
            Console.WriteLine(successMessage);
        }
        static int mode() 
        {
            Console.WriteLine("What Difficulty: ");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.WriteLine("Enter Difficulty By Numer: ");
            string difficulty = Console.ReadLine();
            Int32.TryParse(difficulty, out int num);
            return num switch
            {
                1 => 8,
                2 => 6,
                3 => 4,
                _ => int.MaxValue
            };
        }
        static void Main(string[] args)
        {
            int Difficulty = mode();
            var num = new Random();
            AskFor("Guess the Numer Between 1- 10", "You sir are amazing", "Leave now!",  num.Next(0, 10), Difficulty);
        }
    }
}
