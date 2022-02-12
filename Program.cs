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
            int position = 0;
            DiceRolling diceRolling = new DiceRolling();
            int diceNumber = diceRolling.DiceRoll();
            Console.WriteLine(diceNumber);
        }
    }
}
