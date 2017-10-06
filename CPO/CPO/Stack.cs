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

            private Node First;
            private int size;

            public MyStack()
            {
                size = 0;
                First = null;
            }

            public int Count //параметр для вывода размера 
            {
                get { return size; }
                set { size = value; }
            }

            public T Pop() //метод взятия с вершины
            {
                if (First == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    Node temp = First;
                    if (First.Next != null)
                    {
                        First.Next.Prev = null;
                    }
                    First = First.Next;
                    Count--;
                    return temp.Value;
                }
            }

            public void Push(T newElement)
            {
                Node newNode = new Node(newElement);

                if (First == null)
                {
                    First = newNode;
                }
                else
                {
                    newNode.Next = First;
                    First = newNode; //First и newNode указывают на один и тот же объект
                    newNode.Next.Prev = First;
                }
                Count++;
            }

            public Node Peek()
            {
                if (First == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    Node temp = First;
                    if (First.Next != null)
                    {
                        First.Next.Prev = null;
                    }
                    First = First.Next;
                    return temp;
                }
            }
        }
    }
}
    
