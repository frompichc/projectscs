using System;

namespace GuessingNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorretc = false;
            Random random = new Random();

            int randomNum = random.Next(1, 20);
            int guessNumber = 0;
            Console.WriteLine("Welcome to the guessing number game!");
            Console.WriteLine("A number betwen 1 to 20 will be generated. Guess the right number to win");
            

            while (!isCorretc) 
            {
                Console.WriteLine("Please write a number");
                guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber < randomNum) {
                    Console.WriteLine("Too low, please guess again");
                } else if (guessNumber > randomNum) {
                    Console.WriteLine("Too high, please guess again");
                } else {
                    Console.WriteLine("You have won !!");
                    isCorretc = true;
                }

            }

            Console.WriteLine("Press any key to finishs the game");
            Console.ReadKey();
        }
    }
}