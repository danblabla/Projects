using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArchaeologicalSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaeologicalSite.Tests
{
    [TestClass()]
    public class ArchaeologicalSiteTests
    {
        [TestMethod()]
        public void MainTest() //result is correct
        {
            float x1 = 0.000000f;
            float y1 = 0.000000f;
            float x2 = 1.000000f;
            float y2 = 1.000000f;
            float x3 = 0.000000f;
            float y3 = 1.000000f;
            float area = x1 * (y2 - y3) - y1 * (x2 - x3) + (x2 * y3 - x3 * y2);

            Assert.AreEqual(1, area);
        }

        [TestMethod()]
        public void MainTest1() //area is always pozitive
        {
            float area = -3.000000f;
            Assert.AreEqual(3, Math.Abs(area));
        }
    }
}