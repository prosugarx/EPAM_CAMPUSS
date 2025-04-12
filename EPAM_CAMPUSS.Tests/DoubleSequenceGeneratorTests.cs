using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS.Tests
{
    [TestClass]
    public class DoubleSequenceGeneratorTests
    {
        [TestMethod]
        public void TestDoubleSequence()
        {
            var generator = new DoubleSequenceGenerator(1.5, 3.0);
            Assert.AreEqual(4.5, generator.GetNext());
            Assert.AreEqual(7.5, generator.GetNext());
        }
    }
}
