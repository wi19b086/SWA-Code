using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1.Stack
{
    class EinzelnesElement<T>
    {

        public T WertdesElements { get; set; } //Stores the value of the staack entry
        public EinzelnesElement<T> Elementunterhalb { get; set; } //points to the successor of this entry => the entry which was eded before this one
    }


}

