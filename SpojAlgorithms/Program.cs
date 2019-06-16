using System;


namespace SpojAlgorithms
{
    public class Test
    {
        static long ReverseLong(long _x)
        {    
            
            long _remainder;
            long reverse = 0;
            long _temp = _x;
            while (_temp > 0)
            {
                _remainder = _temp % 10;
                reverse = reverse * 10 + _remainder;
                _temp /= 10;
            }
            return reverse ;
        }
        static bool IsPalindrome(long _x)
        {
            //string original = _x.ToString();
            //var reversed = new string(original.Reverse().ToArray());
            //var palindrome = original == reversed;
            //return palindrome;
            if (ReverseLong(_x) == _x) return true; else { return false; };
        }

        public static void Main()
        {
            int numbersCount = Convert.ToInt32(Console.ReadLine());
            int[] arrayInput = new int[numbersCount];
            string[] arrayOutput = new string[numbersCount];
            for (int i = 0; i < numbersCount; i++)
            {
                arrayInput[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            
            for (int i = 0; i < arrayInput.Length; i++)
            {
                if (arrayInput[i].ToString().Length <= 1)
                {
                    arrayOutput[i] += arrayInput[i];
                    arrayOutput[i] += " ";
                    arrayOutput[i] += "0";
                }
                else
                {
                    int counter = 0;
                    long _number = arrayInput[i];
                    while (IsPalindrome(_number) == false)
                    {
                        string _string = _number.ToString();
                        //string _stringReversed = new string(_string.Reverse().ToArray());
                        //long _numberReversed = Convert.ToInt64(_stringReversed);
                        long _numberReversed = ReverseLong(_number);
                        long _numberInner = _number + _numberReversed;
                        _number = _numberInner;
                        counter++;
                        
                        arrayOutput[i] = _number.ToString();
                        arrayOutput[i] += " ";
                        arrayOutput[i] += counter.ToString();
                    }
                }
            }
            foreach (string line in arrayOutput)
            {
                foreach (char c in line)
                {
                    int a;
                    if (int.TryParse(c.ToString(),out a))
                    { Console.Write(Convert.ToInt16(a.ToString())); }
                        else { Console.Write(c.ToString()); }
                }
                //Console.WriteLine(line);
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}