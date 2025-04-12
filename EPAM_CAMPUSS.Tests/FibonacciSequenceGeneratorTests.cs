using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS.Tests
{
    [TestClass]
    public class FibonacciSequenceGeneratorTests
    {
        [TestMethod]
        public void TestFibonacciSequence()
        {
            var generator = new FibonacciSequenceGenerator(1, 1);
            Assert.AreEqual(2, generator.GetNext()); // İlk adım
            Assert.AreEqual(3, generator.GetNext()); // İkinci adım
            Assert.AreEqual(5, generator.GetNext()); // Üçüncü adım
        }

        [TestMethod]
        public void TestFibonacciInitialValues()
        {
            var generator = new FibonacciSequenceGenerator(0, 1);
            Assert.AreEqual(1, generator.GetNext()); // İlk adım
            Assert.AreEqual(1, generator.GetNext()); // İkinci adım
        }
    }
}
