using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyTestProject
{   
    [TestFixture]
    class CircleTest
    {
        [Test]
        public void perTest()
        {
            Circle n = new Circle();
            double x = 2.0;
            double expectedValue = 4 * Math.PI;
            double actualValue = n.per(x);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void AreaTest()
        {
            Circle n = new Circle();
            double x = 2.0;
            double expectedValue = 4 * Math.PI;
            double actualValue = n.Area(x);
            Assert.AreEqual(expectedValue, actualValue);
        }


    }
}
