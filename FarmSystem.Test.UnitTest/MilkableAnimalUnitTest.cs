using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmSystem.Test;

namespace FarmSystem.Test.UnitTest
{
    [TestClass]
    public class MilkableAnimalUnitTest
    {
        [TestMethod]
        public void ProduceMilk_Cow_AreEqual()
        {
            //Arrange
            IMilkableAnimal cow = new Cow();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            cow.ProduceMilk();

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Cow was milk!\r\n", output);
        }
    }
}
