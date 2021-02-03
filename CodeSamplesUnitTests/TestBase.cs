using System;
using NUnit.Framework;

namespace UnitTestProject
{
    [SetUpFixture]
    public class GlobalSetUpClass
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTestsInNamespace()
        {
            // this is executed once only before any tests in this namespace
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            // this is executed once only after any tests in this namespace
        }
    }
}