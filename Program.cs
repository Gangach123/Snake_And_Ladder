using System;

namespace snake_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inintializing constant
            const int LADDER = 1;
            const int NOPLAY = 2;
            const int SNAKE = 3;

            //UC_1
            int position = 0;
            Random random = new Random();

            //UC_2
            int noOnDie = random.Next(1, 7);
            Console.WriteLine($"No on die:{noOnDie}");

            int options = random.Next(1, 4);

            switch (options)
            {
                case LADDER:
                    position += noOnDie;
                    break;

                case SNAKE:
                    position -= noOnDie;
                    break;

                case NOPLAY:
                    Console.WriteLine("POSITION" + position);
                    break;
            }
            Console.WriteLine("POSITION: " + position);
        }
    }

}