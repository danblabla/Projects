using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paving.Tests
{
    [TestClass()]
    public class PavingTests
    {
        [TestMethod()]
        public void MainTest()
        {
            float L = -2;
            float L1 = 2;
            float l = 0;
            float a = 1;
            float b = 1;

            Assert.AreEqual(L1, Math.Abs(L)); //even if are negative, result is always pozitve

            Assert.AreEqual(0, (L * l) / (a * b)); //if market length or market breadth are 0, result is always 0


        }

        [TestMethod()]
        public void MainTest1()
        {

            float a = 4;
            float b = 0;
            Assert.AreEqual(0, a * b);

        }

        [TestMethod()]
        public void MainTest2()
        {

            float L = 6;
            float l = 6;
            float a = 4;
            float b = 4;
            int N = 4;
            Assert.AreEqual(4,N);
        }
    }
}