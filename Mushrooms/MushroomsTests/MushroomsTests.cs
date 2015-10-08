using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mushrooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mushrooms.Tests
{
    [TestClass()]
    public class MushroomsTests
    {
        [TestMethod()]
        public void MainTest()
        {
            int total = 10;
            int x = 4;
            Assert.AreEqual(true, total % (x + 1) == 0);
        }

        [TestMethod()]
        public void MainTest1()
        {
            //int white = 2;
            //int red = 8;
            int total = 10;
            int x = 4;
            Assert.AreEqual(2,total/(x+1));
            Assert.AreEqual(8, total-total/(x+1));
        }
    }
}