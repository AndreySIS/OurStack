using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPO
{
    class Stack
    {
        public class MyStack<T>
        {
            public class Node
            {
                private T _Value;
                private Node _Next;
                private Node _Prev;
                public T Value
                {
                    get { return _Value; }
                    set { _Value = value; }
                }
                public Node(T Value)
                {
                    this._Value = Value;
                }
                public Node Next
                {
                    get { return this._Next; }
                    set { this._Next = value; }
                }
                public Node Prev
                {
                    get { return this._Prev; }
                    set { this._Prev = value; }
                }
            }
        }
    }
}
    
