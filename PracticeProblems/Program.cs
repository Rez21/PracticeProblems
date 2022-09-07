using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Problems");
            Console.WriteLine("Enter a number to select Problem");
            Console.WriteLine("1. Check Character Is Vowel or Not");
            Console.WriteLine("2. Check if Number is Positive,Negative Or Zero");
            Console.WriteLine("3. Check Largest among three numbers");
            Console.WriteLine("4. Print Alphabets from a to z");
            Console.WriteLine("5. Check largest number using ternary opertor");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    VowelCheck vowelCheck = new VowelCheck();
                    vowelCheck.Alphabet();
                    break;

                case 2:
                    NumberCheck numberCheck = new NumberCheck();
                    numberCheck.NumberPositiveNegative();
                    break;
                case 3:
                    LargestAmongThree largestAmongThree = new LargestAmongThree();
                    largestAmongThree.LargestCheck();
                    break;
                case 4:
                    PrintAlphabets printAlphabets = new PrintAlphabets();
                    printAlphabets.AlphabetPrint();
                    break;
                case 5:
                    LargestUsingTernary largestUsingTernary = new LargestUsingTernary();
                    largestUsingTernary.MaximumCheck();
                    break;
            }
        }
    }
}