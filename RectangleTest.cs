using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyTestProject
{

    [TestFixture]
    class RectangleTest
    {
        [Test]
        public void perTest()
        {
            Rectangle r = new Rectangle();
            double x = 2.0;
            double y = 3.0;
            double expectedValue = 10.0;
            double actualVlaue = r.per(x, y);
            Assert.AreEqual(expectedValue, actualVlaue);
        }

        [Test]
        public void AreaTest()
        {
            Rectangle r = new Rectangle();
            double x = 5.0;
            double y = 10.0;
            double expectedValue = 50.0;
            double actualValue = r.Area(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}
