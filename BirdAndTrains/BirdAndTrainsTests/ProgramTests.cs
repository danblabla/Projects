using Microsoft.VisualStudio.TestTools.UnitTesting;
using BirdAndTrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAndTrains.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTestBirdSpeed()
        {
            float birdspeed = 20;
            Assert.AreEqual(true, birdspeed > 0);
        }

        [TestMethod()]
        public void MainTesttrainSpeed()
        {
            float trainspeed = 10;
            Assert.AreEqual(true, trainspeed > 0);
        }

        [TestMethod()]
        public void MainTestDistance()
        {
            float distance = 100;
            Assert.AreEqual(true, distance > 0);
        }

        [TestMethod()]
        public void MainTestBirddistance()
        {
            float birddistance = 75;
            Assert.AreEqual(true, birddistance>0);
        }
    }
}