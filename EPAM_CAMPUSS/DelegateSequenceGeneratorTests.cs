using EPAM_CAMPUSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS
{
    public class DelegateSequenceGeneratorTests<T> : SequenceGeneratorTests<T>
    {
        private readonly Func<T, T, T> _generateNext;

        public DelegateSequenceGeneratorTests(T first, T second, Func<T, T, T> generateNext) : base(first, second)
        {
            _generateNext = generateNext;
        }

        public override T Next => throw new NotImplementedException();

        public override T GetNext()
        {
            // Temsilci kullanarak bir sonraki elemanı hesapla
            T next = _generateNext(Previous, Current);
            Previous = Current;
            Current = next;
            Count++;
            return next;
        }
    }
}
