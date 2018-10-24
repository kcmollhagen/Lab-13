using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Validation
    {

        public bool enemy(string input)

        {
            // validates that only inputs of b or c will work
            if (input != "b" || input != "c")
            {
                Console.WriteLine("I'm sorry, that is not a valid input. Please enter b or c");
                // only inputs of b or c will work
                return false;
            }
            
            else
            {
                return true;
            }

        }

        public bool action (string input)
            {
                if (input != "R" || input !="P" || input !="S")
                    {
                        Console.WriteLine("I'm sorry, that is not a valid input.  Please enter R or P or S");
                        return false;
                    }

                else
                    {
                    return true;
                    }
        }
    }
}