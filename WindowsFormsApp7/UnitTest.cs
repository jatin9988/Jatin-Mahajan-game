using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WindowsFormsApp7
{
    [TestFixture]
    class UnitTest
    {
        [TestCase]//it is the postive test case
        public void positiveTest()
        {
            Game p = new Game();
            Assert.AreEqual(1, p.spin(6));
        }

        [TestCase]//it is negavtive test case
        public void negativeTest()
        {
            Game n = new Game();
            Assert.AreNotEqual(2, n.spin(6));
        }
    }
}
