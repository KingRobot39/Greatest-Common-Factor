using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD_Dylan_Hughes
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //declareing all ints and bool variables used
            int a;
            int b;
            int c = 0;
            int gcf = 0;
            bool aa;
            bool bb;

            //program's user instructions
            Console.WriteLine("This programm takes two nonzero integers and returns their greatest common factor.");

            Console.WriteLine("Please enter the first integer");

            //parsing the first int
            aa = int.TryParse(Console.ReadLine(), out a);

            //if first parse fails then this loop will keep asking the user for a valid number
            while (aa == false || a == 0)
            {
                Console.WriteLine("Please enter a valid nonzero integer.");

                aa = int.TryParse(Console.ReadLine(), out a);
            }
            
            Console.WriteLine("Please enter the second integer");

            //parsing the second int
            bb = int.TryParse(Console.ReadLine(), out b);

            //if second parse fails then this loop will keep asking the user for a valid number
            while (bb == false || b == 0)
            {
                Console.WriteLine("Please enter a valid nonzero integer.");

                bb = int.TryParse(Console.ReadLine(), out b);
            }

            //processing
            //if statement determines the largest input
            if (a > b)
            {
                c = a;
            }

            else if (b > a)
            {
                c = b;
            }

            //this else makes sure that c is assigned if the two inputs are equal
            else
            {
                c = a;
            }

            //this loop finds the gcf by moding the inputs and looking for a remainder of zero
            for (int i = 1; i <= c; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcf = i;
                }
            }

            //output
            //displays the result above for the user
            if (gcf == 1)
            {
                Console.WriteLine($"The integers {a} and {b} have no greatest common factor.");
            }

            else
            {
                Console.WriteLine($"The greatest common factor of {a} and {b} is {gcf}.");
            }

            Console.ReadLine();
        }
    }
}
