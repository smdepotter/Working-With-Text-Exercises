using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Working_With_Text_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise5();
        }

        static void Exercise1()
        /* Write a program an ask the user to enter a few numbers separated by a hyphen.
         Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9"
         or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display 
         "Not Consecutive".
         */
        {
            Console.WriteLine("Give me a few numbers. Separate with hyphen");

            var userInput = Console.ReadLine();
            var numbers = userInput.Split("-").Select(n => Convert.ToInt32(n)).ToList();
            var isConsecutive = true;

            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1] + 1) continue;
                Console.WriteLine("Non Consecutive, Program Stop");
                isConsecutive = false;
                break;
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

        static void Exercise4()
        {
            /*
             * Write a program and ask the user to enter a few words separated by a space.
             * Use the words to create a variable name with PascalCase. For example,
             * if the user types: "number of students", display "NumberOfStudents".
             * Make sure that the program is not dependent on the input.
             * So, if the user types "NUMBER OF STUDENTS",
             * the program should still display "NumberOfStudents". 
             */

            Console.WriteLine("Enter a few words. Separate by Space");

            var userInput = Console.ReadLine();
            var words = new List<string>();
            var pascalCaseConversion = new StringBuilder();

            words.AddRange(userInput.Split(" "));


            foreach (var word in words)
            {
                var lower = word.Substring(1).ToLower();
                var upper = word.First().ToString().ToUpper();
                pascalCaseConversion.Append(upper + lower);

            }

            Console.WriteLine(pascalCaseConversion);

        }

        static void Exercise5()
        {
            /*
             * Write a program and ask the user to enter an English word.
             * Count the number of vowels (a, e, o, u, i) in the word.
             * So, if the user enters "inadequate", the program should display 6 on the console.
             */

            Console.WriteLine("Enter an English Word");

            var userInput = Console.ReadLine();
            var characters = new List<char>();
            characters.AddRange(userInput.ToCharArray());

            var letterA = 0;
            var letterE = 0;
            var letterI = 0;
            var letterO = 0;
            var letterU = 0;

            foreach (var character in characters)
            {
                if (character == 'a')
                    ++letterA;
                else if (character == 'e')
                    ++letterE;
                else if (character == 'i')
                    ++letterI;
                else if (character == 'o')
                    ++letterO;
                else if (character == 'u') ++letterU;
            }

            var total = letterA + letterE + letterI + letterO + letterU;

            Console.WriteLine(@"You had a total of {0} Vowels
                                A: {1}
                                E: {2}
                                I: {3}
                                O: {4}
                                U: {5}",
                total, letterA, letterE, letterI, letterO, letterU);
        }
    }
}
