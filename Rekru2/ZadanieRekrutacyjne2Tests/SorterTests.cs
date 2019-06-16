using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZadanieRekrutacyjne2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne2.Tests
{
    [TestClass()]
    public class SorterTests
    {
        [TestMethod()]
        public void ReplaceAllWhiteSpacesTest()
        {
            var x = Sorter.ReplaceAllWhiteSpaces("a a a");
            Assert.AreEqual(x, "aaa");
        }
        [TestMethod()]
        public void ReplaceAllWhiteSpacesTest1()
        {
            var x = Sorter.ReplaceAllWhiteSpaces("a' a a");
            Assert.AreEqual(x, "aaa");
        }
        [TestMethod()]
        public void ReplaceAllWhiteSpacesTest2()
        {
            var x = Sorter.ReplaceAllWhiteSpaces("/ @ #");
            Assert.AreEqual(x, "");
        }

        [TestMethod()]
        public void SortTest()
        {
            var x = Sorter.Sort("a3 b2 c1");
            Assert.AreEqual(x[0].Original, "c1");
        }
        [TestMethod()]
        public void SortTest1()
        {
            var x = Sorter.Sort("a3 b2 c1");
            Assert.AreEqual(x[1].Original, "b2");
        }
        [TestMethod()]
        public void SortTest2()
        {
            var x = Sorter.Sort("a3 b2 c1");
            Assert.AreEqual(x[2].Original, "a3");
        }
    }
}