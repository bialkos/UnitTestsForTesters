using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestsFortTesters;

namespace UnitTestTraining
{
    [TestFixture]
    public class StoreControllerTest
    {
        private StoreController storeController { get; set; }

        [SetUp]
        public void SetUp()
        {
            storeController = new StoreController();
        }

        [Category("StoreController")]
        [TestCase(-12332)]
        [TestCase(-7334)]
        [TestCase(-1)]
        public void GetStore_ReturnException(int value)
        {
            //Act
            
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> { storeController.GetStore(value); });
        }

        [Category("StoreController")]
        [TestCase(0)]
        public void GetStore_ReturnNotFound(int value)
        {
            //Act
            var result = storeController.GetStore(value);
            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.TypeOf<NotFound>());
                Assert.That(result, Is.InstanceOf<ActionResult>());
            }); 
        }

        [Category("StoreController")]
        [TestCase(1)]
        [TestCase(654)]
        [TestCase(65388)]
        public void GetStore_ReturnOk(int value)
        {
            //Act
            var result = storeController.GetStore(value);
            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.TypeOf<Ok>());
                Assert.That(result, Is.InstanceOf<ActionResult>());
            });
        }
    }
}
