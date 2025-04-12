using EPAM_CAMPUSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EPAM_CAMPUSS
{
    
        public class IntegerSequenceGenerator : SequenceGeneratorTests<int>
        {
            public IntegerSequenceGenerator(int first, int second) : base(first, second) { }

        public override int Next => Current;

        public override int GetNext()
            {
                int next = 6 * Current - 8 * Previous; // Formüle göre hesaplama
                Previous = Current;
                Current = next;
                Count++;
                return next;
            }
        }
    
}
