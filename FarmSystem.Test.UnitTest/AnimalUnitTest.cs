using FarmSystem.Test;

namespace FarmSystem.Test.UnitTest
{
    [TestClass]
    public class AnimalUnitTest
    {
        [TestMethod]
        public void Talk_Horse_AreEqual()
        {
            //Arrange
            IAnimal horse = new Horse();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            horse.Talk();

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Horse says neigh!\r\n", output);
        }

        [TestMethod]
        public void DefaultVariables_Horse_AreEqual()
        {
            //Arrange
            IAnimal horse = new Horse();

            //Act

            //Assert
            Assert.AreEqual(4, horse.NoOfLegs);
            Assert.AreEqual("Horse", horse.Species);
        }

        [TestMethod]
        public void Talk_Sheep_AreEqual()
        {
            //Arrange
            IAnimal sheep = new Sheep();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            sheep.Talk();

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Sheep says baa!\r\n", output);
        }

        [TestMethod]
        public void DefaultVariables_Sheep_AreEqual()
        {
            //Arrange
            IAnimal sheep = new Sheep();

            //Act

            //Assert
            Assert.AreEqual(4, sheep.NoOfLegs);
            Assert.AreEqual("Sheep", sheep.Species);
        }

        [TestMethod]
        public void Talk_Cow_AreEqual()
        {
            //Arrange
            IAnimal cow = new Cow();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            cow.Talk();

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Cow says Moo!\r\n", output);
        }

        [TestMethod]
        public void DefaultVariables_Cow_AreEqual()
        {
            //Arrange
            IAnimal cow = new Cow();

            //Act

            //Assert
            Assert.AreEqual(4, cow.NoOfLegs);
            Assert.AreEqual("Cow", cow.Species);
        }

        [TestMethod]
        public void Talk_Hen_AreEqual()           
        {
            //Arrange
            IAnimal hen = new Hen();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            hen.Talk();

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Hen says CLUCKAAAAAWWWWK!\r\n", output);
        }


        [TestMethod]
        public void DefaultVariables_Hen_AreEqual()
        {
            //Arrange
            IAnimal hen = new Hen();

            //Act

            //Assert
            Assert.AreEqual(2, hen.NoOfLegs);
            Assert.AreEqual("Hen", hen.Species);
        }

        [TestMethod]
        public void Talk_Animal_AreEqual()
        {
            //Arrange
            IAnimal animal = new Animal();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            animal.Talk();

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Unknown animal makes a noise\r\n", output);
        }

        [TestMethod]
        public void DefaultVariables_Animal_AreEqual()
        {
            //Arrange
            IAnimal animal = new Animal();

            //Act

            //Assert
            Assert.AreEqual(0, animal.NoOfLegs);
            Assert.AreEqual("Unknown animal", animal.Species);
        }

        [TestMethod]
        public void Walk_Animal_AreEqual()
        {
            //Arrange
            IAnimal animal = new Hen();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            animal.Walk();

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual($"{animal.Species} is walking\r\n", output);
        }

        [TestMethod]
        public void Run_Animal_AreEqual()
        {
            //Arrange
            IAnimal animal = new Hen();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            animal.Run();

            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual($"{animal.Species} is running\r\n", output);
        }
    }
}