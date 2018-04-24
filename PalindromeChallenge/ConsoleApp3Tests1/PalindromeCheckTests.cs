using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Tests
{
    [TestClass()]
    public class PalindromeCheckTests
    {

        [TestMethod()]
        public void CheckTextTestTrue()
        {
            string x1 = "racecar";
            PalindromeCheck x = new PalindromeCheck(x1);
            bool test1 = x.CheckText(x1);
            Assert.AreEqual(test1, true);

        }

        [TestMethod()]
        public void CheckTextTestTrueCI()
        {
            string x1 = "Racecar";
            PalindromeCheck x = new PalindromeCheck(x1);
            bool test1 = x.CheckText(x1);
            Assert.AreEqual(test1, true);

        }

        [TestMethod()]
        public void CheckTextTestTrueCINum()
        {
            string x1 = "1221";
            PalindromeCheck x = new PalindromeCheck(x1);
            bool test1 = x.CheckText(x1);
            Assert.AreEqual(test1, true);

        }

        [TestMethod()]
        public void CheckTextTestTrueCIIgnorePunc()
        {
            string x1 = "Race..car";
            PalindromeCheck x = new PalindromeCheck(x1);
            bool test1 = x.CheckText(x1);
            Assert.AreEqual(test1, true);

        }

        [TestMethod()]
        public void CheckTextTestFalse()
        {
            string x1 = "q;aeiubvql;ruij";
            PalindromeCheck x = new PalindromeCheck(x1);
            bool test1 = x.CheckText(x1);
            Assert.AreEqual(test1, false);
        }


    }
}