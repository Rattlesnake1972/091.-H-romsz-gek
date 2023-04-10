using Microsoft.VisualStudio.TestTools.UnitTesting;
using haromszogekCLITests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using haromszogekCLI;

namespace haromszogekCLITests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void derekszoguTest()
        {
            Assert.AreEqual(true, Program.derekszogu(3, 4, 5));
            Assert.AreEqual(true, Program.derekszogu(6, 8, 10));
            Assert.AreEqual(false, Program.derekszogu(2, 4, 5));

        }
    }
}
