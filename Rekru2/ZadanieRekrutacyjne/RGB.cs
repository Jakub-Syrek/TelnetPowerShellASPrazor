using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    public class RGB
    {
        private byte _r = 0;
        private byte _g = 0;
        private byte _b = 0;

        public byte R
        {
            get { return _r; }
            set { _r = value; }
        }
        public byte G
        {
            get { return _g; }
            set { _g = value; }
        }
        public byte B
        {
            get { return _b; }
            set { _b = value; }
        }

        public  string DecToHex(byte decim)
        {
            if (decim <= 0)
                return "00";

            int hx = decim;
            string hexStr = string.Empty;

            while (decim > 0)
            {
                hx = decim % 16;

                if (hx < 10)
                    hexStr = hexStr.Insert(0, Convert.ToChar(hx + 48).ToString());
                else
                    hexStr = hexStr.Insert(0, Convert.ToChar(hx + 55).ToString());

                decim /= 16;
            }

            return hexStr;
        }
        public  string RGBToHexadecimal(RGB col)
        {
            string rHex = DecToHex(col.R);
            string gHex = DecToHex(col.G);
            string bHex = DecToHex(col.B);

            return $"#{rHex}{gHex}{bHex}";
        }
    }
}
