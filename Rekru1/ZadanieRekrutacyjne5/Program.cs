using System;
using System.Collections.Generic;

namespace ZadanieRekrutacyjne5
{
    static class S
    {
        static int SumAllEven(int[] arr)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenList.Add(arr[i]);
                }
                else if (arr[i] % 2 != 0)
                {
                    oddList.Add(arr[i]);
                }
            }

            int result = 0;

            foreach (var item in evenList)
            {
                result = result + item;
            }
            return result;
        }
        public static void ReturnEven()
        {
            string input = "";
            int t = 0;

            while (input == "")
            {
                Console.WriteLine("Please provide input numbers splitted by empty space to filter for even:");
                string input1 = Console.ReadLine();
                string[] input1splitted = input1.Split(Convert.ToChar(" "));
                int[] inputInts = new int[input1splitted.Length];
                for (int i = 0; i<input1splitted.Length; i++)
                {
                    if (int.TryParse(input1splitted[i], out t))
                    {
                        inputInts[i] = int.Parse(input1splitted[i]);
                    }
                    else
                    {
                        
                    }
                }                
                var sumOfAllEvenNumbersInList = S.SumAllEven(inputInts);
                Console.WriteLine($"Sum of all even = {sumOfAllEvenNumbersInList} ");               
            }
        }
    }
    class Program
    {   

        static void Main(string[] args)
        {
            S.ReturnEven();
            Console.ReadLine();
        }
    }
}
