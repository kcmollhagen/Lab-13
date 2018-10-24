using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            
            // create random
            Random r = new Random();

            bool shouldAskQuestions = true;
            while (shouldAskQuestions == true)
            {
                // The program will continue to run if prompted by user
                // sending Random to askQuestions
                AskQuestions(name, r);
                Console.WriteLine("Would you like to continue y/n");

                string answer = Console.ReadLine();
                if (answer != "y")
                {
                    shouldAskQuestions = false;
                }
            }
        }

        static void AskQuestions(string name, Random r)
        {
            Validation v = new Validation();
            Player p = new Rocky();
            do
            {
                
                Console.WriteLine("Would you like to play against The Bloods or The Crips (b/c)?");
                string input = Console.ReadLine();
                bool check = v.enemy(input);
                Console.WriteLine();

                if(check == true)
                {
                    break;
                }
                

            } while (true);


            string action;

            do
            {
                Console.WriteLine("Rock, Paper, or Scissors? (R/P/S)");
                action = Console.ReadLine().ToUpper();
                bool check = v.action(action);
                Console.WriteLine();

                if (check == true)
                {
                    break;
                }

            } while (true);



            if (action == "R")
            {
                action = RPS.Rock;
            }


            if (action == "P")
            {
                action = RPS.Paper;
            }

            if (action == "S")
            {
                action = RPS.Scissors;
            }

            // sending Random to RPS
            string enemy = p.GenRPS(r);
            Console.WriteLine(name + " threw " + action);
            Console.WriteLine("They threw " + enemy);
            int win = RPS.Check(action, enemy);

            if (win == 0)
            {
                Console.WriteLine("You lost!");
            }
            else if (win == 1)
            {
                Console.WriteLine("Tie!");
            }
            else if (win == 2)
            {
                Console.WriteLine("Winner winner chicken dinner!");
            }
            Console.WriteLine();
        }
    }
}
