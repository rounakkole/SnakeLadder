using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class DiceRolling
    {
        public bool gameEnd { get; set; }
        public int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }

        public int Function()
        {
            Random random = new Random();
            int functionNumber = random.Next(1, 4);
            //Console.WriteLine(functionNumber);
            return functionNumber;
        }

        public int UserTurn(int turnNumber)
        {
            turnNumber = turnNumber == 1 ? 2 : 1;
            //Console.WriteLine(turnNumber);
            return turnNumber;
        }
    }
}
