using System;

namespace snake_And_Ladder
{
    class snake_And_Ladder
    {
        static void Main(string[] args)
        {
            //Inintializing constant
            const int LADDER = 1;
            const int NOPLAY = 2;
            const int SNAKE = 3;
            const int targetposition = 100;

            //UC_1
            int position = 0;
            Random random = new Random();

            while (position != 100)
            {
                int noOnDie = random.Next(1, 7);
                Console.WriteLine($"No on die :{noOnDie}");

                int options = random.Next(1, 4);
                switch (options)
                {
                    case LADDER:
                        position += noOnDie;
                        int positionofPlayer = position < 0 ? position += noOnDie : position;
                        Console.WriteLine($"Player position was incrimented :{position}");

                        break;

                    case SNAKE:
                        position -= noOnDie;
                        int positionofPlayer1 = position >100  ? position -= noOnDie : position;
                        Console.WriteLine($"Player position was decrimented :{position}");
                        break;

                    case NOPLAY:
                        Console.WriteLine("POSITION: " + position);
                        break;
                }

            }
           Console.WriteLine("POSITION of the player: " + position);
        }
    }

}