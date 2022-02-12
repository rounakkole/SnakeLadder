// See https://aka.ms/new-console-template for more information
using System;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("snake ladder game");
            GamePlay();
        }

        public static void GamePlay()
        {
            //constants
            const int LADDER = 1;
            const int SNAKE = 2;
            const int NO_PLAY = 3;

            DiceRolling diceRolling = new DiceRolling();
            UserInfo user = new UserInfo();


            while (user.UserPosition < 100)
            {
                //variables
                int diceNumber = diceRolling.DiceRoll();
                int functionNumber = diceRolling.Function();
                Console.WriteLine(diceNumber);
                switch (functionNumber)
                {
                    case LADDER:
                        //user.UserPosition= user.UserPosition + diceNumber <= 100? user.UserPosition: user.UserPosition + diceNumber;
                        if (user.UserPosition + diceNumber <= 100)
                        {
                            user.UserPosition += diceNumber;
                        }
                        break;
                    case SNAKE:
                        if (user.UserPosition > diceNumber)
                        {
                            user.UserPosition -= diceNumber;
                        }
                        else
                        {
                            user.UserPosition = 0;
                            Console.WriteLine("user position negative");
                        }
                        break;
                    case NO_PLAY:
                        Console.WriteLine("no play");
                        break;
                    default:
                        Console.WriteLine("default case error");
                        break;
                }
                Console.WriteLine(user.UserPosition);
            }
        }
    }
}
