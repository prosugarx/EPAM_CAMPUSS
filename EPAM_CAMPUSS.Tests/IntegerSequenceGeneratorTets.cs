using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS.Tests
{
    [TestClass]
    public class IntegerSequenceGeneratorTests
    {
        [TestMethod]
        public void TestIntegerSequenceGeneration()
        {
            var generator = new IntegerSequenceGenerator(2, 4);
            Assert.AreEqual(8, generator.GetNext());
            Assert.AreEqual(16, generator.GetNext());
        }

        [TestMethod]
        public void TestIntegerInitialValues()
        {
            var generator = new IntegerSequenceGenerator(1, 3);
            Assert.AreEqual(4, generator.GetNext());
        }
    }
}
