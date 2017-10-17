using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPO
{
    public class MyStack2<T> : IMyStack<T>
    {
        T[] a;
        int top = 0;
        public MyStack2 (int size)
        {
            a = new T[size];

        }
        public int Count
        {
            get
            {
                return top;
            }
            set { }
        }
        public void Push(T value)
        {
            a[top] = value;
            top++;
        }
        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            return a[top - 1];
        }
        public T Pop()
        {
            T value = Peek();
            top--;
            return value;
        }
    }
}
