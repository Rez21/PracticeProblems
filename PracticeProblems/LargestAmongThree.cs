using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class LargestAmongThree
    {
        public void LargestCheck()
        {
            Console.WriteLine("Enter three numbers: \n");

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                if (number1 > number3)
                    Console.WriteLine(number1 + " is the largest number");
                else
                    Console.WriteLine(number3 + " is the largest number");
            }

            else if (number2 > number3)
                Console.WriteLine(number2 + " is the largest number");

            else
                Console.WriteLine(number3 + " is the largest number");

            Console.ReadLine();
        }
    }
}
