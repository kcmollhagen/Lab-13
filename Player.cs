using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Player
    {
        string name;
        string RPSValue;

        public Player(string name)
        {
            this.name = name;
        }

        public virtual string GenRPS(Random r)
        {
            int pick = r.Next(0, 3);
            switch (pick)
            {
                case 0:
                    return RPS.Rock;
                    break;
                case 1:
                    return RPS.Paper;
                    break;
                case 2:
                    return RPS.Scissors;
                    break;
                default:
                    return RPS.Rock;
                    break;
            }
        }


    }
}
