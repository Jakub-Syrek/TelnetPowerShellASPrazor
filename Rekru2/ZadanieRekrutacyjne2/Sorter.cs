using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne2
{
    public class Sorter
    {
        private string _input;
        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        public static string ReplaceAllWhiteSpaces(string str)
        {
            var x = Regex.Replace(str, @"(\[|""|\])", "");
            x = Regex.Replace(x, @"(\[|\|\])", "");
            x = Regex.Replace(x, @"(\[|'|\])", "");
            x = Regex.Replace(x, @"(\[|/|\])", "");
            x = Regex.Replace(x, @"(\[|@|\])", "");
            x = Regex.Replace(x, @"(\[|()|\])", "");
            x = Regex.Replace(x, @"(\[|#|\])", "");
            x = Regex.Replace(x, @"(\[|\|\])", "");
            x = Regex.Replace(x, @"(\[|''|\])", "");
            x = Regex.Replace(x, @"(\[|;|\])", "");
            x = Regex.Replace(x, @"(\[|:|\])", "");

            return Regex.Replace(x, @"\s+", "");
        }
        public static List<StriNumber> Sort(string s)
        {
            String[] unsorted = s.Split(Convert.ToChar(" "));

            List<StriNumber> strinum = new List<StriNumber>();

            int[] numbers = new int[unsorted.Length];

            byte b = 0;

            int c = 0;

            for (int i = 0; i < unsorted.Length; i++)
            {
                StriNumber stri = new StriNumber();

                foreach (char cz in unsorted[i])
                {

                    var x = ReplaceAllWhiteSpaces(cz.ToString());
                    //build copy
                    stri.Original += x.ToString();

                    //filter numbers
                    if (byte.TryParse(x.ToString(), out b))
                    {
                        stri.LiteralNumeric += x.ToString();

                    }

                    //exclude white chars
                    else if (!char.IsWhiteSpace(cz))
                    {
                        stri.Literal += x.ToString();

                    }
                }
                if (int.TryParse(stri.LiteralNumeric, out c))
                {
                    stri.Numeric = int.Parse(stri.LiteralNumeric);
                }
                strinum.Add(stri);
            }
            //Sorting by number
            strinum = strinum.OrderBy(x => x.Numeric).ToList();

            return strinum;

        }
    }
}
