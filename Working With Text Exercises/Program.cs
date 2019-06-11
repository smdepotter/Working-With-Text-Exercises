﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace Working_With_Text_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise3();
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
            /*Write a program and ask the user to enter a few numbers separated by a hyphen.
             If the user simply presses Enter, without supplying an input, exit immediately;
             otherwise, check to see if there are duplicates. If so, display "Duplicate"
             on the console.
             */

            Console.WriteLine("Enter a few numbers. Separate with hyphen");

            var userInput = Console.ReadLine();
            var numbers = userInput.Split("-").Select(n => Convert.ToInt32(n)).ToList();
            numbers.Sort();

            if (String.IsNullOrWhiteSpace(userInput)) Environment.Exit(1);

            var repeatedNumbers = new List<int>();
            var repeatedNumbersStringBuilder = new StringBuilder();


            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    //added func; shows user repeated numbers
                    if (!repeatedNumbers.Contains(numbers[i]))
                    {
                        repeatedNumbers.Add(numbers[i]);
                    }
                }
            }

            if (repeatedNumbers.Count() != 0)
            {
                foreach (var number in repeatedNumbers)
                {
                    repeatedNumbersStringBuilder.Append(number + ",");

                }

                Console.WriteLine("Duplicates Found: " + repeatedNumbersStringBuilder);
            }
            else
            {
                Console.WriteLine("No Duplicates");
            }

            
        }

        static void Exercise3()
        {
            /*Write a program and ask the user to enter a time value in the 24-hour
             time format
             (e.g. 19:00). A valid time should be between 00:00 and 23:59.
             If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
             If the user doesn't provide any values, consider it as invalid time.
             */

            Console.WriteLine("Enter a time");

            TimeSpan span;
            if (TimeSpan.TryParse(Console.ReadLine(), out span)) Console.WriteLine("Ok");
            else
            {
                Console.WriteLine("Invalid Time");
            }

        }
    }
}
