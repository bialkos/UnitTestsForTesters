using NUnit.Framework;
using UnitTestsFortTesters;

namespace Tests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        private HtmlFormatter formatter;

        [SetUp]
        public void Setup()
        {
            formatter = new HtmlFormatter();
        }

        [TestCase("abc")]
        public void FormatAsBold_GivenString_ReturnStringWrappedWithStrongElement (string input)
        {
            var result = formatter.FormatAsBold(input);

            //general assertion
            Assert.That(result, Is.EqualTo($"<strong>{input}</strong>").IgnoreCase);
            
            //general assertion 2
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            
            //specific assertion
            Assert.That(result, Is.EqualTo($"<strong>abc</strong>"));
        }


        [Category("specific assertions tests")]
        [TestCase("abc")]
        [TestCase("dEf")]
        [TestCase("GHi")]
        public void FormatAsBold_GivenSpecificString_ReturnStringWrappedWithStrongElement(string input)
        {
            var result = formatter.FormatAsBold(input);

            //specific assertion
            Assert.That(result, Is.EqualTo($"<strong>{input}</strong>"));
        }

        [Category("general assertions tests")]
        [TestCase("abc")]
        [TestCase("dEf")]
        [TestCase("GHi")]
        public void FormatAsBold_GivenString_ReturnStringWrappedWithStrongElements(string input)
        {
            var result = formatter.FormatAsBold(input);

            //specific assertion
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
        }


        [Category("general assertions tests")]
        [TestCase("abc")]
        [TestCase("dEf")]
        [TestCase("GHi")]
        public void FormatAsBold_GivenString_ReturnStringWrappedWithStrongElements_multipleAsserts(string input)
        {
            var result = formatter.FormatAsBold(input);

            //specific assertion with Assert.Multiple() method
            Assert.Multiple(() =>
            {
                Assert.That(result, Does.StartWith("<strong>"));
                Assert.That(result, Does.EndWith("</strong>"));
            });
        }
    }
}