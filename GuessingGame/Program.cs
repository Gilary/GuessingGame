using System;

namespace GuessingGame
{
    class Game
    {
        static int Guess=8;
        static int Target=7;
        static string Input = "";
        static Random RandomNumber = new Random();
        public static void Play()
        {
            //statements to run the game
            Console.WriteLine("I look deep into the depths of my crystal ball and see a number floating to the surface. Can you what guess what number between 1 and 10 I am thinking of... ?");
            Target = RandomNumber.Next(10) + 1;
            Input = Console.ReadLine();
            if (int.TryParse(Input, out Guess))
            {
                if (Guess == Target)
                {
                    //match - congratulations!
                    Console.WriteLine("congratulations! You guessed " + Guess + " and the number I was thinking of was " + Target + ", so you guessed it right!");
                }
                else
                {
                    //no match - try again
                    Console.WriteLine("Bummer! You guessed " + Guess + " and the number I was thinking of was " + Target + ", so you guessed it wrong!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Play();
            }
            Console.Read();
        }
       
    }
    class Program
    {
        static void Main()
        {
            Game.Play();
        }
    }
}
