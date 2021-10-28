using System;

namespace Homework_4._8_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int MaxRangeNumber;
            int GameNumber;
            int PlayerNumber;
            string Exit;

            Console.WriteLine("Enter max range number 1 to 255: ");
            MaxRangeNumber = int.Parse(Console.ReadLine());

            //проверка диапозона 
            while (MaxRangeNumber < 1 || MaxRangeNumber > 255)
            {
                Console.WriteLine("Enter Correct max range number 1 to 255: ");
                MaxRangeNumber = int.Parse(Console.ReadLine());
            }

            //генерируем число
            Random rand = new Random();
            GameNumber = rand.Next(1, MaxRangeNumber);
            Console.WriteLine($"game number {GameNumber}"); //Пока пусть будет

            PlayerNumber = -1;

            while (PlayerNumber < 1 || PlayerNumber > 255 || GameNumber != PlayerNumber)
            {
                Console.WriteLine("Enter number 1 to 255: ");
                Exit = Console.ReadLine();
                if (Exit == "")
                {
                    Console.WriteLine($"You are tiered! Game nuber is: {GameNumber}");
                    break;
                } else
                {
                    PlayerNumber = int.Parse(Exit);
                }
                if (GameNumber == PlayerNumber)
                {
                    Console.WriteLine($"You won! Game number is: {GameNumber}");
                    break;
                } else if (GameNumber < PlayerNumber) {
                    Console.WriteLine($"Game number is lower");
                } else
                {
                    Console.WriteLine($"Game number is upper");
                }
            }

            Console.ReadKey();
        }
    }
}
