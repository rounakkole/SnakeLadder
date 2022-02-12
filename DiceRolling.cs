using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class DiceRolling
    {
        public int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
    }
}
