using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ZadanieRekrutacyjne2
{


    class Program
    {

        static void Main(string[] args)
        {

            string input = "";

            while (input == "")
            {
                Console.WriteLine("Please provide input words with numbers splitted by empty spaces as a single string:");
                string input1 = Console.ReadLine();

                var listSorted = Sorter.Sort(input1);

                string output = "";

                foreach (var item in listSorted)
                {
                    //output += $"{item.Literal}{item.Numeric} "; 
                    output += $"{item.Original} ";
                }
                Console.WriteLine(output.Trim());
            }
        }
    }
}



