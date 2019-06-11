using System;
using System.Collections.Generic;
using System.Linq;

namespace Working_With_Text_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
        }

        static void Exercise1()
        /* Write a program and ask the user to enter a few numbers separated by a hyphen.
         Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9"
         or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display 
         "Not Consecutive".
         */
        {
            Console.WriteLine("Give me a few numbers. Separate with hyphen");

            var userInput = Console.ReadLine();
            var numbers = userInput.Split("-").Select(n => Convert.ToInt32(n)).ToList();
            var isConsecutive = true;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    Console.WriteLine("Non Consecutive, Program Stop");
                    isConsecutive = false;
                    break;
                }
            }

            if (isConsecutive) Console.WriteLine("Consecutive");
        }

        static void Exercise2()
        {

        }
    }
}
