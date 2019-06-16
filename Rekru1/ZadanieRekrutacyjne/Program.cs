using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{


    public class Program
    {
        public static void RGB()
        {
            byte r, g, b = 0;
            RGB data = new RGB();

            while (data.R == 0)
            {
                Console.WriteLine("Please provide R:");
                string input1 = Console.ReadLine();
              
               if (byte.TryParse(input1, out r))
               {
                    if (byte.Parse(input1) == 0)
                    {
                        data.R = 0;
                        break;
                    }
                    data.R = byte.Parse(input1);
}
               else
               {
                     Console.WriteLine("Wrong input format");
               }
               
            }
            while (data.G == 0)
            {
                Console.WriteLine("Please provide G:");
                string input2 = Console.ReadLine();
                if (byte.TryParse(input2, out g))
                {
                    if (byte.Parse(input2) == 0)
                    {
                        data.G = 0;
                        break;
                    }
                    data.G = byte.Parse(input2);
                }
                else
                {
                    Console.WriteLine("Wrong input format");
                }
            }
            while (data.B == 0)
            {
                Console.WriteLine("Please provide B:");
                string input3 = Console.ReadLine();
                if (byte.TryParse(input3, out b))
                {
                    if (byte.Parse(input3) == 0)
                    {
                        data.B = 0;
                        break;
                    }
                    data.B = byte.Parse(input3);
                }
                else
                {
                    Console.WriteLine("Wrong input format");
                }
            }
            if (data != null)
            {                  
                Console.WriteLine($"{data.RGBToHexadecimal(data)}");
            }
             }
        static void Main(string[] args)
        {
            
            

            RGB();
            Console.ReadKey();
        }
    }
}
