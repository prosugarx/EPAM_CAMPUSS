using EPAM_CAMPUSS.EPAM_CAMPUSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS
{
    public class DoubleSequenceGenerator : SequenceGenerator<double>
    {
        public DoubleSequenceGenerator(double first, double second) : base(first, second) { }

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
