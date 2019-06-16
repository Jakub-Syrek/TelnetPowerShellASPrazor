using System;
using System.Collections.Generic;
using System.Linq;


namespace ZadanieRekrutacyjne3
{
    internal class Pump
    {
        private int _workAssigned = 0;

        internal int WorkAssigned
        {
            get { return _workAssigned; }
            set { _workAssigned = value; }
        }

    }
    internal class Station
    {
        private string _original;
        private int _carsNumber;
        private int[] _carsTime;
        private int _pumpNumbers;

        internal string Original
        {
            get { return _original; }
            set { _original = value; }
        }
        internal int CarsNumber
        {
            get { return _carsNumber; }
            set { _carsNumber = value; }
        }
        internal int[] CarsTime
        {
            get { return _carsTime; }
            set { _carsTime = value; }
        }
        internal int PumpNumbers
        {
            get { return _pumpNumbers; }
            set { _pumpNumbers = value; }
        }
        internal Stack<int> st = new Stack<int>();
        internal Stack<int> ConvertToStack(int[] _x)
        {
            Stack<int> _st = new Stack<int>();
            foreach (var item in _x)
            {
                _st.Push(item);
            }
            return _st;
        }
        internal int CountAllListElements(List<Pump> _list)
        {
            int _res = 0;
            foreach (var item in _list)
            {
                _res = _res + item.WorkAssigned;
            }
            return _res;
        }
        internal int ReturnSecondsToResolveLine()
        {
             int time = 0;
            Station station = new Station();
            station.st = new Stack<int>();
            byte r = 0;
            int g = 0;
            while (station.CarsNumber == 0)
            {

                Console.WriteLine("Please provide number of cars standing in the line");
                string input1 = Console.ReadLine();

                if (byte.TryParse(input1, out r))
                {
                    if (byte.Parse(input1) == 0)
                    {
                        station.CarsNumber = 0;
                        break;
                    }
                    station.CarsNumber = byte.Parse(input1);
                }
                else
                {
                    Console.WriteLine("Wrong input format");
                }
            }
            int numberIn = station.CarsNumber;
            station.CarsTime = new int[numberIn];

            for (int i = 0; i < station.CarsNumber; i++)
            {
                Console.WriteLine($"Please provide time in units for car number {i + 1}");

                string time1= Console.ReadLine();

                if (int.TryParse(time1, out g))
                {
                    if (int.Parse(time1) == 0)
                    {
                        station.CarsTime[i] = 0;
                        break;
                    }
                    else
                    {
                        station.CarsTime[i] = int.Parse(time1);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input format");
                }

            }

            while (station.PumpNumbers == 0)
            {

                Console.WriteLine("Please provide number of pumps available at the station:");
                string input1 = Console.ReadLine();

                if (byte.TryParse(input1, out r))
                {
                    if (byte.Parse(input1) == 0)
                    {
                        station.PumpNumbers = 0;
                        break;
                    }
                    station.PumpNumbers = byte.Parse(input1);
                }
                else
                {
                    Console.WriteLine("Wrong input format");
                }
            }




            for (int l = station.CarsTime.Length - 1; l >= 0; l--)
            {
                station.st.Push(station.CarsTime[l]);
            }


            List<Pump> pumps = new List<Pump>();

            for (int i = 0; i < station.PumpNumbers; i++)
            {
                Pump p = new Pump();
                pumps.Add(p);
            }
            if ((station.st.Count >= 3) && (station.CountAllListElements(pumps) == 0))
            {
                time--;

            }
            while (station.st != null)
            {
                if ((station.st.Count == 0) && (station.CountAllListElements(pumps) == 0))
                {

                    break;
                }
                while (station.CountAllListElements(pumps) != 0)
                {
                    if ((station.st.Count == 0) && (station.CountAllListElements(pumps) == 0))
                    {
                        //break;
                    }
                    for (int j = pumps.Count - 1; j >= 0; j--)
                    {
                        if ((station.st.Count == 0) && (pumps[j].WorkAssigned == 0))
                        {
                            pumps[j].WorkAssigned = 0;
                            //break;
                        }

                        else if ((pumps[j].WorkAssigned == 0) && (station.st.Count != 0))
                        {
                            pumps[j].WorkAssigned = station.st.Pop();
                            if (pumps[j].WorkAssigned != 0)
                                pumps[j].WorkAssigned -= 1;
                        }
                        else if ((pumps[j].WorkAssigned != 0) && (station.st.Count != 0))
                        {
                            if (pumps[j].WorkAssigned != 0)
                                pumps[j].WorkAssigned -= 1;
                        }
                        else if ((pumps[j].WorkAssigned != 0) && (station.st.Count == 0))
                        {
                            if (pumps[j].WorkAssigned != 0)
                                pumps[j].WorkAssigned -= 1;

                        }
                    }
                    time++;
                    //pumps = pumps.OrderBy(x => x.WorkAssigned).ToList();

                }

                while (station.CountAllListElements(pumps) == 0)
                {
                    if ((station.st.Count == 0) && (station.CountAllListElements(pumps) == 0))
                    {

                        break;
                    }
                    for (int j = 0; j < pumps.Count - 1; j++)
                    {
                        if ((station.st.Count == 0) && (pumps[j].WorkAssigned == 0))
                        {
                            pumps[j].WorkAssigned = 0;
                            break;
                        }
                        if ((pumps[j].WorkAssigned == 0) && (station.st.Count != 0))
                        {
                            pumps[j].WorkAssigned = station.st.Pop();
                            pumps[j].WorkAssigned -= 1;
                        }
                        else if ((pumps[j].WorkAssigned == 0) && (station.st.Count == 0))
                        {
                            pumps[j].WorkAssigned = 0;

                        }
                        else if ((pumps[j].WorkAssigned != 0) && (station.st.Count == 0))
                        {
                            if (pumps[j].WorkAssigned != 0)
                                pumps[j].WorkAssigned -= 1;

                        }
                        else if ((pumps[j].WorkAssigned != 0) && (station.st.Count != 0))
                        {
                            if (pumps[j].WorkAssigned != 0)
                                pumps[j].WorkAssigned -= 1;

                        }
                    }
                    time++;
                    //pumps = pumps.OrderBy(x => x.WorkAssigned).ToList();
                }
            }
            return time;
            
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Station st = new Station();
            int time = st.ReturnSecondsToResolveLine();
            Console.WriteLine($"All cars in line will be fuelled at the end of second: {time}");
            Console.ReadKey();
        }
    }
}
