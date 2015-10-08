using Microsoft.VisualStudio.TestTools.UnitTesting;
using Goats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goats.Tests
{
    [TestClass()]
    public class GoatsTests
    {
        [TestMethod()]
        public void MainTest()
        {
            float w = 5;
            int y = 0;
            string i = "imposible";
            if (w == 0 || y == 0)
            {
                Assert.AreEqual(0, y);
            }
        }
    }
}