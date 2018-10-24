using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class RPS
    {
        public static string Rock { get { return "Rock"; } }
        public static string Scissors { get { return "Scissors"; } }
        public static string Paper { get { return "Paper"; } }

        public static int Check(string user, string enemy) //0 = loss, 1 = tie, 2 = win
        {
            if (user == Rock)
            {
                if (enemy == Rock)
                {
                    return 1;
                }
                else if (enemy == Paper)
                    {
                    return 0;
                    }
                else if (enemy == Scissors)
                {
                    return 2;
                }
            }


            if (user == Paper)
            {
                if (enemy == Rock)
                {
                    return 2;
                }
                else if (enemy == Paper)
                {
                    return 1;
                }
                else if (enemy == Scissors)
                {
                    return 0;
                }
            }


            if (user == Scissors)
            {
                if (enemy == Rock)
                {
                    return 0;
                }
                else if (enemy == Paper)
                {
                    return 2;
                }
                else if (enemy == Scissors)
                {
                    return 1;
                }
            }


            return 0; //should not reach

        }
    }
}
