using System;
namespace snakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NO_PLAY = 1;
            const int LADDER = 2;
            const int SNAKE = 3;
            Console.WriteLine("Welcome to Snake and Ladder Simulation(Single Player)");
            int playerOnePosition = 0;
            Random random = new Random();
            int dieRoll;
            while (playerOnePosition < 100)
            {
                dieRoll = random.Next(1, 7);
                int check = random.Next(1, 4);
                switch (check)
                {
                    case NO_PLAY:
                        playerOnePosition += 0;
                        break;
                    case LADDER:
                        if((playerOnePosition + dieRoll)<= 100)
                            playerOnePosition += dieRoll;
                        break;
                    case SNAKE:
                        playerOnePosition -= dieRoll;
                        if (playerOnePosition < 0)
                            playerOnePosition = 0;
                        break;
                }
                Console.WriteLine("Position of Player 1 is at " + playerOnePosition);
            }   
        }
    }
}
