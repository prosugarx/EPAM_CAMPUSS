using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS.Tests
{
    [TestClass]
    public class CharSequenceGeneratorTests
    {
        [TestMethod]
        public void TestCharSequence()
        {
            var generator = new CharSequenceGenerator('A', 'B');
            Assert.AreEqual('C', generator.GetNext());
            Assert.AreEqual('D', generator.GetNext());
        }
    }
}
