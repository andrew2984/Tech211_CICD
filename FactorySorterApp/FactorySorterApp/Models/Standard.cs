using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorySorterApp.Controller;

namespace FactorySorterApp.Models
{
    public class Standard : ISorter
    {
        //public for now to test
        public ArrayGenerator _array;

        public Standard(ArrayGenerator array)
        {
            _array = array;
        }
        public void Sort()
        {
            Array.Sort(_array.SortableArray);
        }
    }
}
