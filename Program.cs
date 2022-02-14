using System;

namespace Snake_And_Ladder
{
   internal class Snake_And_Ladder
    {
        static void Main(string[] args)
        {
            //UC_2
            //int position = 0;
            Random random = new Random();
            int noOnDie = random.Next(1, 7);
            Console.WriteLine($"No on die:{noOnDie}");
        }
    }
}

