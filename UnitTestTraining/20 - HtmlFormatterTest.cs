using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestsFortTesters;

namespace UnitTestTraining
{
    [TestFixture]
    public class HtmlFormatterTest
    {
        private HtmlFormatter html { get; set; }

        [SetUp]
        public void SetUp()
        {
            html = new HtmlFormatter();
        }

        [Category("BoldHTML")]
        [TestCase("test")]
        [TestCase(" lala")]
        [TestCase("fsdfomds fsdgfd gfdg df ")]
        public void FormatAsBold_OpenStrongTag(string value)
        {
            //Act
            var result = html.FormatAsBold(value);
            //Assert
            Assert.That(result, Does.StartWith("<strong>"));
        }

        [Category("BoldHTML")]
        [TestCase("test")]
        [TestCase(" lala")]
        [TestCase("fsdfomds fsdgfd gfdg df ")]
        public void FormatAsBold_CloseStrongTag(string value)
        {
            //Act
            var result = html.FormatAsBold(value);
            //Assert
            Assert.That(result, Does.EndWith("</strong>"));
        }

        [TestCase("abc")]
        public void FormatAsBold_ReturnStringInBold(string value)
        {
            //Act
            var result = html.FormatAsBold(value);
            //Assert
            Assert.That(result, Is.EqualTo($"<strong>{value}</strong>").IgnoreCase);
        }
    }
}
