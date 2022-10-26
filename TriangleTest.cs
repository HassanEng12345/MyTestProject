using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyTestProject
{   
    [TestFixture]
    class TriangleTest
    {
        [Test]
        public void perTest()
        {
            Triangle t = new Triangle();
            double x = 2.0;
            double y = 8.0;
            double z = 5.0;
            double expectedValue = 15.0;
            double actualValue = t.per(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void AreaTest()
        {
            Triangle t = new Triangle();
            double x = 10.0;
            double y = 10.0;
            double z = 10.0;
            double expectedValue = 25*Math.Sqrt(3);
            double actualValue = t.Area(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
