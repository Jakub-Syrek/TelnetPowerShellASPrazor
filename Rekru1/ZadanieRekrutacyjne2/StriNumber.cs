using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne2
{
    public struct StriNumber
    {
        private string _original;
        private int _num;
        private string _literalNumeric;
        private string _literal;
        public string Original
        {
            get { return _original; }
            set { _original = value; }
        }
        public int Numeric
        {
            get { return _num; }
            set { _num = value; }
        }
        public string LiteralNumeric
        {
            get { return _literalNumeric; }
            set { _literalNumeric = value; }
        }

        public string Literal
        {
            get { return _literal; }
            set { _literal = value; }
        }
    }
}
