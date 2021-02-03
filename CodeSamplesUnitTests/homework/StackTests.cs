using System;
using NUnit.Framework;
using UnitTestsFortTesters;

namespace Tests
{
    [TestFixture]
    class StackTests
    {
        private Stack<object> stack;

        [SetUp]
        public void Setup()
        {
            stack = new Stack<object>();
        }

        [Test]
        public void Count_WhenStackIsEmpty_CountIsZero()
        {
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_WhenCalledWithNullArgument_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => stack.Push(null));
        }

        [Test]
        public void Push_WhenCalledWithAnObject_IncreasesListCount()
        {
            stack.Push(new object());
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_WhenCountIsZero_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }


        [Test]
        public void Pop_WhenCalled_DecreasesListCountAndReturnsLastObject()
        {
            stack.Push("first string");
            stack.Push("middle string");
            stack.Push("last string");

            var result = (string)stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
            Assert.That(result, Is.EqualTo("last string"));
        }

        [Test]
        public void Peek_WhenCountIsZero_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Test]
        public void Peek_WhenCalled_ReturnsLastObjectAndDoesNotChangeCount()
        {
            stack.Push("first string");
            stack.Push("middle string");
            stack.Push("last string");

            var result = (string)stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));
            Assert.That(result, Is.EqualTo("last string"));
        }
    }
}
