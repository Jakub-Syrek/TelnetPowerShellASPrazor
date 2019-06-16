using System;


namespace ZadanieRekrutacyjne4
{
    public class IGetCircum
    {
        private double _Radius;
        public double Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }
        double GetCircumference(Func<double, double> f)
        {
            return f(_Radius);
        }
        public double GetCircumference(Func<double, double> f,double _Radius)
        {
            return f(_Radius);
        }
    }
    public sealed class Circle : IGetCircum
    {
        private double _Radius;        

        public double GetCircumference(Func<double,double> f)
        {
            return f(_Radius);
        }
    } 
   
    class Program
    {
        static Func<double, double> foo = dbl =>  ((2 * Math.PI) * dbl);
        static void Main(string[] args)
        {
            Console.Write("Radius: ");           
            double radius = double.Parse(Console.ReadLine());            

            Circle c = new Circle();
            c.Radius = radius;            
            var result = c.GetCircumference(foo, c.Radius);            
            Console.WriteLine("Perimeter = {0:F2}", result);

            Console.ReadKey();
        }
    }
}
