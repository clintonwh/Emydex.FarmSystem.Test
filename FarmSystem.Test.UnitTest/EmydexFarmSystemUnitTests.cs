using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test.UnitTest
{
    [TestClass]
    public class EmydexFarmSystemUnitTests
    {
        [TestMethod]
        public void MakeNoise_NoAnimalsInTheFarm_AreEqual()
        {
            //Arrange
            IEmydexFarmSystem farmSystem = new EmydexFarmSystem();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            farmSystem.MakeNoise();

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual("There are no animals in the farm\r\n", output);
        }

        [TestMethod]
        public void Enter_OneAnimalsInTheFarm_AreEqual()
        {
            //Arrange
            IEmydexFarmSystem farmSystem = new EmydexFarmSystem();
            IAnimal animal = new Animal();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            farmSystem.Enter(animal);

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual($"{animal.Species} has entered the Emydex farm\r\n", output);
        }

        [TestMethod]
        public void Enter_MultipleAnimalsInTheFarm_AreEqual()
        {
            //Arrange
            IEmydexFarmSystem farmSystem = new EmydexFarmSystem();
            IAnimal horse = new Horse();
            IAnimal hen = new Hen();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            farmSystem.Enter(horse);
            farmSystem.Enter(hen);

            //Assert
            var output = System.Text.RegularExpressions.Regex.Split(stringWriter.ToString(), "\r?\n");
            Assert.AreEqual($"{horse.Species} has entered the Emydex farm", output[0]);
            Assert.AreEqual($"{hen.Species} has entered the Emydex farm", output[1]);
        }

        [TestMethod]
        public void MakeNoise_OneAnimalInTheFarm_AreEqual()
        {
            //Arrange
            IEmydexFarmSystem farmSystem = new EmydexFarmSystem();
            IAnimal animal = new Animal();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            string expectedOuput = $"{animal.Species} makes a noise";

            //Act
            farmSystem.Enter(animal);
            farmSystem.MakeNoise();

            //Assert
            var output = System.Text.RegularExpressions.Regex.Split(stringWriter.ToString(), "\r?\n");
            Assert.AreEqual(expectedOuput, output[1]);
        }

        [TestMethod]
        public void MakeNoise_MultipleAnimalsInTheFarm_AreEqual()
        {
            //Arrange
            IEmydexFarmSystem farmSystem = new EmydexFarmSystem();
            IAnimal horse = new Horse();
            IAnimal hen = new Hen();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            farmSystem.Enter(horse);
            farmSystem.Enter(hen);
            farmSystem.MakeNoise();

            //Assert
            var output = System.Text.RegularExpressions.Regex.Split(stringWriter.ToString(), "\r?\n");
            Assert.AreEqual("Horse says Neigh!", output[2]);
            Assert.AreEqual("Hen says CLUCKAAAAAWWWWK!", output[3]);
        }

        [TestMethod]
        public void MilkAnimals_NoMilkableAnimalPresent_AreEqual()
        {
            //Arrange
            IEmydexFarmSystem farmSystem = new EmydexFarmSystem();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            farmSystem.MilkAnimals();

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Cannot identify the farm animals which can be milked\r\n", output);
        }

        [TestMethod]
        public void MilkAnimals_MilkableAnimalPresent_AreEqual()
        {
            //Arrange
            IEmydexFarmSystem farmSystem = new EmydexFarmSystem();
            IMilkableAnimal animal = new Cow();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            farmSystem.Enter(animal);
            farmSystem.MilkAnimals();

            //Assert
            var output = System.Text.RegularExpressions.Regex.Split(stringWriter.ToString(), "\r?\n");
            Assert.AreEqual($"{animal.Species} was milk!", output[1]);
        }
    }
}
