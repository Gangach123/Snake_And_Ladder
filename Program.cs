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

            //Variables
            int position = 0;
            Random random = new Random();
            int counter = 0;

            int player1Position = 0;
            int player2Position = 0;

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
                counter++;
                int position = 0;
                int position1 = 0;
                while (position != targetposition && position1 != targetposition)
                {
                    position = Main(position);
                    position1 = Main(position1);
                    Console.WriteLine($"PLAYER1 IS AT {player1Position} & PLAYER2 IS AT {player2Position}");
                }
                string result = position == targetposition ? ("Player1 Won the game") : ("Player2 won the game");
                Console.WriteLine(result);


            }
            Console.WriteLine("POSITION of the player: " + position);
        }
         

    }

}