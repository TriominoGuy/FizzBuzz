using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int input1, input2, looplength = 0;
            Console.WriteLine("Welcome to FizzBuzz.\nIn this program, you must enter an integer value for Fizz, " +
                "an integer value for Buzz, and an integer value for length.\nThe program will then count up to the " +
                "given length.\nEverytime it hits a number which is a multiple of Fizz, it will write \"Fizz\" instead\n" +
                "And the same thing happens for Buzz.\nWhen it hits a number that is a multiple of both, it will write \"FizzBuzz\".");
            while (true)
            {
                Console.WriteLine("Please input Fizz");
                if (!int.TryParse(Console.ReadLine(), out input1))
                {
                    Console.WriteLine("Invalid input, please try again");
                    continue;
                }               
                else
                    break;
            }
            while (true)
            {
                Console.WriteLine("Please input Buzz");
                if (!int.TryParse(Console.ReadLine(), out input2))
                {
                    Console.WriteLine("Invalid input, please try again");
                    continue;
                }
                else
                    break;
            }
            while (true)
            {
                Console.WriteLine("Please input length");
                if (!int.TryParse(Console.ReadLine(), out looplength))
                {
                    Console.WriteLine("Invalid input, please try again");
                    continue;
                }
                else
                    break;
            }
            for (int x = 1; x <= looplength; x++)
            {
                if (x % input1 == 0 && x % input2 ==0)
                    Console.WriteLine("FizzBuzz");
                else if (x % input1 == 0)
                    Console.WriteLine("Fizz");
                else if (x % input2 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(x);
            }
            Console.WriteLine($"You inputted {input1} for Fizz");
            Console.WriteLine($"You inputted {input2} for Buzz");
            Console.WriteLine("Press Enter to exit");
            Console.ReadKey();


        }
    }
}
