using System;
using System.Collections.Generic;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = 0;
            var secondtNumber = 0;
            //var operator = 0;


            var input = Console.ReadLine();

            var values = input.Split(' ');

            List<string> numbers = new List<string>();

            foreach (var value in values)
            {
                if ( value != "")
                {
                    numbers.Add(value);
                }
            }

            if (numbers[0] !="" && numbers[2] !="")
            {
                firstNumber = Int32.Parse(numbers[0]);
                secondtNumber = Int32.Parse(numbers[2]);
            }

            switch (numbers[1])
            {
                case "-":
                    Console.WriteLine(firstNumber - secondtNumber);
                    break;
                case "+":
                    Console.WriteLine(firstNumber + secondtNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondtNumber);
                    break;
                case "/":
                    Console.WriteLine(firstNumber / secondtNumber);
                    break;
                default:
                    Console.WriteLine("Something went wrong");
                    break;
                    
        }



            //int number;
            //Console.WriteLine(words);

            //var succeded = Int32.TryParse(input, out number);

            //if(succeded == true)
            //{
            //    Console.WriteLine($"Input was multiplied by 2 {number*2}");
            //}
            //else
            //{
            //    Console.WriteLine("Error while parsing");
            //}
        }
    }
}
