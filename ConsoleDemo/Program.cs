using System;
using System.Collections.Generic;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int number;

            var succeded = Int32.TryParse(input, out number);

            if(succeded == true)
            {
                Console.WriteLine($"Input was multiplied by 2 {number*2}");
            }
            else
            {
                Console.WriteLine("Error while parsing");
            }
        }
    }
}
