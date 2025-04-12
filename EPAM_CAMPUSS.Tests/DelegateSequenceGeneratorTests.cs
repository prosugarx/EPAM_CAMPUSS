using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS.Tests
{
    [TestClass]
    public class DelegateSequenceGeneratorTests
    {
        [TestMethod]
        public void TestDelegateSequence()
        {
            Func<int, int, int> customRule = (prev, current) => prev + current * 2;
            var generator = new DelegateSequenceGenerator<int>(1, 2, customRule);
            Assert.AreEqual(5, generator.GetNext());
            Assert.AreEqual(9, generator.GetNext());
        }
    }
}
