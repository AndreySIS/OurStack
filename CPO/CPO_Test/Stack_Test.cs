using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPO;
using NUnit.Framework;

namespace CPO_Test
{
    public class Stack_Test
    {
        [Test()]
        public void Count_Test()
        {
            MyStack<int> stack = new MyStack<int>();
            int expected = 0;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Peek_EmptyStack_Test()
        {
            MyStack<int> stack = new MyStack<int>();
            CPO.MyStack<int>.Node actual = stack.Peek();

        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_EmptyStack_Test()
        {
            MyStack<int> stack = new MyStack<int>();
            int actual = stack.Pop();
        }

        

        [Test()]
        public void Push_Test()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            int expected = 1;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Peek_Test()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            int expected = 1;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Push_Test1()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            int expected = 2;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Pop_Test()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            int expected = 1;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Pop_Test2()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Pop();
            int expected = 0;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Pop_Test3()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int expected = 3;
            int actual = stack.Pop();
            Assert.AreEqual(expected, actual);
            expected = 2;
            actual = stack.Pop();
            Assert.AreEqual(expected, actual);
            expected = 1;
            actual = stack.Pop();
            Assert.AreEqual(expected, actual);
        }
    }
}
