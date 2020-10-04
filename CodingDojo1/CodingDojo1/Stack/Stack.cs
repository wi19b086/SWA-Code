using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1.Stack
{
    class Stack<T>
    {

        private EinzelnesElement<T> oberstesElement;

        public void Push(T item)
        {
            if (oberstesElement == null)
            {
                oberstesElement = new EinzelnesElement<T>() { WertdesElements = item, Elementunterhalb = null };
            }

            else
            {
                EinzelnesElement<T> tmp = new EinzelnesElement<T> { WertdesElements = item, Elementunterhalb = oberstesElement };
                oberstesElement = tmp;
            }
        }


        public T Pop()
        {
            if (oberstesElement!= null)
            {
                T tmp = oberstesElement.WertdesElements;
                oberstesElement = oberstesElement.Elementunterhalb;
                return tmp;
            }

            else
            {
                throw new NullReferenceException();
            }
        }


        public T Peek()
        {
            if (oberstesElement!=null)
            {
                return oberstesElement.WertdesElements;
            }
            else
            {
                return default(T);
            }
        }

    }
}
