using System;


namespace ZadanieRekrutacyjne6
{
    class Program
    {
        private static DateTime t;
        private static String s;
        static void Main(string[] args)
        {
            Console.WriteLine(t == null ? "t is null" : t.ToString());
            //(Bool)Condition ? Consequence : Alternative
            //If 't' equals null, display "t is null" , else display datetime t converted to string "t.ToString()"
            //1/1/0001 12:00:00 AM
            Console.WriteLine(t.GetType().ToString());
            //System.DateTime
            Console.WriteLine($"{t.GetType().ToString()} after initialisation is declared with default value of :'{t.ToString()}' {"\r\n"}which means it is not null or empty.");
            Console.WriteLine(s ?? "s is null");
            //s is null and reference type needs to be declared
            //The null-coalescing operator ?? returns the value of its left-hand operand if it isn't null; otherwise, it evaluates the right-hand operand and returns its result. 
           
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("String s is null valued and needs to be declared");
                Console.ReadKey();
                Console.WriteLine($@"Declaring empty string  s ='' ");
                
                s = "" ;
                
                //Testing wheter empty string will be accepted
                if (string.IsNullOrEmpty(s))
                {
                    Console.WriteLine(s == null ? "s is null" : $"s is {s.Length} chracter long, and now it has a type:{s.GetType().ToString()}");
                    Console.ReadKey();
                    //Declaring string with one char
                    Console.WriteLine($@"Declaring one char long string  s =' '   ");
                    s = " ";
                    Console.WriteLine($"string s length = {s.Length}");
                    //Testinghow the string behaves now
                    Console.WriteLine(s == null ? "s is null" : $"s is {s.Length} chracter long, and now it has a type:{s.GetType().ToString()}");
                }
                else
                {
                    Console.WriteLine(s == null ? "s is null" : $"s is {s.Length} chracter long, and now it has a type:{s.GetType().ToString()}");
                }
                   
            }
            else
            {
                Console.WriteLine(s == null ? "s is null" : $"s is {s.Length} chracter long, and now it has a type:{s.GetType().ToString()}");
            }           
            Console.ReadKey();
        }
    }
}
