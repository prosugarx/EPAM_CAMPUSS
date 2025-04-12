using EPAM_CAMPUSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS
{
    public class FibonacciSequenceGenerator : SequenceGenerator<int>
    {
        public FibonacciSequenceGenerator(int first, int second) : base(first, second) { }

        public override int Next => Current;

        public override int GetNext()
        {
            int next = Previous + Current; // Fibonacci kuralı: Xn = Xn-1 + Xn-2
            Previous = Current;
            Current = next;
            Count++;
            return next;
        }
    }
}
