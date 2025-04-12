using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS
{
    public interface ISequenceGenerator<T>
    {
            T Previous { get; }
            T Current { get; }
            T Next { get; }
        
    }
}
