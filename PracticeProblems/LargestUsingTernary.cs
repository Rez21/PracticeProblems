using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class LargestUsingTernary
    {
        public void MaximumCheck()
        {
            Console.WriteLine("Enter three numbers: \n");

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            int maximum = (number1 > number2) ? ((number1 > number3) ? number1 : number3) : ((number2 > number3) ? number2 : number3);
            Console.WriteLine("Largest number among {0}, {1} and {2} is: {3}", number1, number2, number3, maximum);
        }
    }
}
