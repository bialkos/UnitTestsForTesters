using System;
using NUnit.Framework;

namespace UnitTestTraining
{
    [TestFixture]
    public class StackTest
    {
        private UnitTestsFortTesters.Stack<string> stack { get; set; }

        [SetUp]
        public void SetUp()
        {
            stack = new UnitTestsFortTesters.Stack<string>();
        }

        [Category("Stack")]
        [Category("StackPush")]
        [Test]
        public void Push_ThrowsException()
        {
            //Assert
            Assert.Throws<ArgumentNullException>(()=> { stack.Push(null); });
        }

        [Category("Stack")]
        [Category("StackPush")]
        [TestCase("Element1")]
        [TestCase("Element2")]
        public void Push_AddsElement(string value)
        {
            //Act
            stack.Push(value);
            string listResult = stack.list[0];
            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(stack.Count == 1);
                StringAssert.Contains(value, listResult);
            });
        }

        [Category("Stack")]
        [Category("StackPop")]
        [Test]
        public void Pop_ThrowsException()
        {
            //Assert
            Assert.Throws<InvalidOperationException>(() => { stack.Pop(); });
        }

        [Category("Stack")]
        [Category("StackPop")]
        [Test]
        public void Pop_RemovesElement()
        {
            //Arrange
            string value1 = "Element1";
            string value2 = "Element2";
            //Act
            stack.Push(value1);
            stack.Push(value2);
            stack.Pop();
            string listResult = stack.list[0];
            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(stack.Count == 1);
                StringAssert.Contains(value1, listResult);
                StringAssert.DoesNotContain(value2, listResult);
            });
        }

        [Category("Stack")]
        [Category("StackPeek")]
        [Test]
        public void Peek_ThrowsException()
        {
            //Assert
            Assert.Throws<InvalidOperationException>(() => { stack.Peek(); });
        }

        [Category("Stack")]
        [Category("StackPeek")]
        [TestCase("Element1")]
        [TestCase("Element2")]
        public void Peek_PeeksElement(string value)
        {
            //Act
            stack.Push("Element0");
            stack.Push(value);
            //Assert
            Assert.AreEqual(value, stack.Peek());
        }
    }
}
