using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int playerRandumNum;

                Random random = new Random();

                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerRandumNum = random.Next(1, 7);

                Console.WriteLine(" You rolled a " + playerRandumNum);


            }

            Console.ReadKey();
          //need to add additional player
        }
    }
}
