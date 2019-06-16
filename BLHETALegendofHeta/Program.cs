using System;
using System.Collections.Generic;
using System.Linq;

namespace BLHETALegendofHeta
{
    public static class Helper
    {
        public static string Remove(this string s, IEnumerable<char> chars)
        {
            return new string(s.Where(c => !chars.Contains(c)).ToArray());
        }
    }
    public class Test
    {

        public static void Main()
        {

            string input = Console.ReadLine();
            char space = Convert.ToChar(" ");
            int N = int.Parse(Console.ReadLine());
            string[] inputArr = new string[N];
            
            for (int i = 0; i < N; i++)
            {                
                inputArr[i] = Console.ReadLine();                                            
            }
            for (int m = 1; m < inputArr.Length; m++)
            {
                if (input.Contains(inputArr[m]))
                {
                    string _inner =  Helper.Remove(input, inputArr[m]);
                    //string _inner = input;

                    //_inner = _inner.Replace(inputArr[m], " ");
                    input = _inner;

                }
            }
            for (int k = 0; k < inputArr.Length ; k++)
            {
                if(input.Contains(inputArr[k]))
                {
                    string _inner = input;
                    
                    _inner = _inner.Replace(inputArr[k]," ");
                    input = _inner;
                    
                }
            }

           
            string result = "";              
            
            foreach (char cz in input)
            {
                if(cz != space)
                {
                    result += cz;
                    input = result;
                }
            }
            for (int l = 0; l < inputArr.Length; l++)
            {
                if (input.Contains(inputArr[l]))
                {
                    string _inner1 = input;
                    _inner1 = _inner1.Replace(inputArr[l], " ");
                    foreach (char cz in _inner1)
                        input = _inner1;
                }
            }
            string result1 = "";
            foreach (char cz in input)
            {
                if (cz != Convert.ToChar(" "))
                {
                    result1 += cz;
                    input = result1;
                }
            }
            Console.WriteLine($"{input}");
            Console.ReadKey();
        }
    }
}
