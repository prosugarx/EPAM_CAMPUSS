using EPAM_CAMPUSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS
{
    public class DoubleSequenceGeneratorTests : SequenceGeneratorTests<double>
    {
        public DoubleSequenceGeneratorTests(double first, double second) : base(first, second) { }

        public override double Next => throw new NotImplementedException();

        public override double GetNext()
        {
            double next = Current + (Previous / Current); // Formüle göre hesaplama
            Previous = Current;
            Current = next;
            Count++;
            return next;
        }
    }
}
