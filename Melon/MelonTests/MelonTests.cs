using Microsoft.VisualStudio.TestTools.UnitTesting;
using Melon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melon.Tests
{
    [TestClass()]
    public class MelonTests
    {
        [TestMethod()]
        public void MainTest()
        {
            int x = 10;

            Assert.AreEqual(true, x % 2 == 0); //x devide 2
        }

        [TestMethod()]
        public void MainTest1()
        {
            int x = 5;
            Assert.AreEqual(true, x > 2); //x >2
        }

        [TestMethod()]
        public void MainTest2()
        {
            int x = 5;
            Assert.AreEqual(false, x % 2 == 0);
        }

        [TestMethod()]
        public void MainTest3()
        {
            int x = 2;
            Assert.AreEqual(false, x>2);
        }
    }
}