﻿using EPAM_CAMPUSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS
{
    public class CharSequenceGenerator : SequenceGenerator<char>
    {
        public CharSequenceGenerator(char first, char second) : base(first, second) { }

        public override char Next => Current;

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
