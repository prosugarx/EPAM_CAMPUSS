using EPAM_CAMPUSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS
{
    public class CharSequenceGeneratorTests : SequenceGeneratorTests<char>
    {
        public CharSequenceGeneratorTests(char first, char second) : base(first, second) { }

        public override char Next => throw new NotImplementedException();

        public override char GetNext()
        {
            // Dizinin kuralına göre bir sonraki karakteri hesapla
            char next = (char)(Current + 1); // Örnek formül
            Previous = Current;
            Current = next;
            Count++;
            return next;
        }
    }
}
