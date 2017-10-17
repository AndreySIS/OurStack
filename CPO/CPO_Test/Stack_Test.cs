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
        private IMyStack<int> stack;
        [SetUp]
        public void SetUp()
        {
            stack = new MyStack<int>();
           // stack = new MyStack2<int>(3);
        }

        [Test()]
        public void Count_Test()
        {
            int expected = 0;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }


        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_EmptyStack_Test()
        {
            int actual = stack.Pop();
        }

        

        [Test()]
        public void Push_Test()
        {
            stack.Push(1);
            int expected = 1;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Peek_Test()
        {
            stack.Push(1);
            int expected = 1;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Push_Test1()
        {
            stack.Push(1);
            stack.Push(2);
            int expected = 2;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Pop_Test()
        {
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
            stack.Push(1);
            stack.Pop();
            int expected = 0;
            int actual = stack.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Pop_Test3()
        {
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
