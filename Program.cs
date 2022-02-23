using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        //CONSTANTS
        const int SNAKE = 1;
        const int LADDER = 2;
        const int targetPosition = 100;
        public static int Getposition(int position)
        {
            //VARIABLES
            Random random = new Random();
            int chooseOption = random.Next(0, 3);
            int dieRoll = random.Next(1, 7);

            switch (chooseOption)
            {
                case SNAKE:
                    position -= dieRoll;
                    position = position < 0 ? position += dieRoll : position;
                    break;
                case LADDER:
                    position += dieRoll;
                    //For decrementing if player crosses 100 position.
                    position = position > targetPosition ? position -= dieRoll : position;
                    //For playing again, if player got at ladder
                    Getposition(position);
                    break;
                default:
                    position += 0;
                    Console.WriteLine("NOT PLAYED");
                    break;
            }
            return position;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder game");

            //VARIABLES
            int player1 = 0;
            int player2 = 0;

            while (player1 != targetPosition && player2 != targetPosition)
            {
                player1 = Getposition(player1);
                player2 = Getposition(player2);
                Console.WriteLine($"PLAYER1 IS AT {player1} & PLAYER2 IS AT {player2}");
            }
            string result = player1 == targetPosition ? ("Player1 Won the game") : ("Player2 won the game");
            Console.WriteLine(result);
        }
    }
}