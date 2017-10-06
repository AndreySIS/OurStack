using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPO
{
    interface IMyStack<T>
    {
        int Count { get; set; }
        T Pop();
        void Push(T newElement);

    }

}
