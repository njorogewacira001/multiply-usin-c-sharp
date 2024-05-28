using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.WriteLine("Enter second number:");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            Console.WriteLine("value of " + numberA + ", " + numberB);
            string answerAInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerAInput);

            if (answer == actualAnswer)
            {
                Console.WriteLine("well done");
            }
            else
            {
                Console.WriteLine("close but incorrect");
            }

            Console.ReadLine();

        }
    }
}
