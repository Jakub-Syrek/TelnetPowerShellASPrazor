using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZadanieRekrutacyjne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne.Tests
{
    [TestClass()]
    public class RGBTests
    {
        [TestMethod()]
        public void DecToHexTest()
        {
            RGB rgb = new RGB();
            byte decim = 10;
            var x = rgb.DecToHex(decim);

            Assert.AreEqual(x, "A");
        }

        [TestMethod()]
        public void RGBToHexadecimalTest()
        {
            RGB rgb = new RGB();
            rgb.R = 10;
            rgb.G = 10;
            rgb.B = 10;
            
            var x = rgb.RGBToHexadecimal(rgb);

            Assert.AreEqual(x, "#AAA");
        }
    }
}