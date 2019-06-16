using System;

class Test
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            int counter = 0;
            string input = Console.ReadLine();
            int inputToNumber = int.Parse(input);
            int reversed = 0;
            string text2 = "";
            do
            {
                for (int j = input.Length -1;  j >= 0;  j--)
                {
                    text2 += input[j];
                }
                reversed = int.Parse(text2);
                if (inputToNumber == reversed)
                {
                    break;
                }
                counter++;
                inputToNumber += reversed;
                input = inputToNumber.ToString();
                text2 = "";

            }
            while(true);
            Console.WriteLine(inputToNumber + "  " + counter);
        }
            
    }

}