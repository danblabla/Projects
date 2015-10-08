using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsMan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsMan.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            int N = 10;

            Assert.AreEqual(100, Math.Pow(N, 2));
        }

        [TestMethod()]
        public void MainTest1()
        {
            float N = 5;
            Assert.AreEqual(5, (int)N);
        }

        [TestMethod()]
        public void MainTest2()
        {
            int N = 2;
            Assert.AreEqual(true, N > 0);
        }

        }
    }
