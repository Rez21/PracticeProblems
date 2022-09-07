using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class NumberCheck
    {
        public void NumberPositiveNegative()
        {
            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Entered number is Zero");
            }else if (number > 0)
            {
                Console.WriteLine("Entered number: " + number + " is Positive");
            }
            else
            {
                Console.WriteLine("Entered number: "+ number + " is Negative");
            }
        }
    }
}
