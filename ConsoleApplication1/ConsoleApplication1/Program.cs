using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static string Reversed(string input)
        {
            string output = "";

            char[] seq = input.ToCharArray();

            Array.Reverse(seq);

            return output;
        }


        static void Main(string[] args)                                                                                                     
        {
            Console.Write("Enter a string: ");

            string input = Console.ReadLine();
            string output = Reversed(input);
            string output = Reverse(Console.ReadLine);

            Console.WriteLine(output);
        }
    }
}


