using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS
{
    
        public abstract class SequenceGeneratorTests<T> : ISequenceGeneratorTests<T> 
        {
            public T Previous { get; protected set; }
            public T Current { get; protected set; }
            public abstract T Next { get; } // Soyut veya türetilen sınıfta uygulanacak.

            public int Count { get; protected set; }

            public SequenceGeneratorTests(T previous, T current)
            {
                Previous = previous;
                Current = current;
                Count = 2; // İlk iki değer zaten tanımlı.
            }

            public abstract T GetNext();
        }
    
}
