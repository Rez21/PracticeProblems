using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class PrintAlphabets
    {
        public void AlphabetPrint()
        {
            Console.WriteLine("Alphabets from a-z are: ");
            for (char character = 'a'; character <= 'z'; character++)
            {
                Console.Write(character + "\t");
            }
            Console.ReadLine();
        }
    }
}
