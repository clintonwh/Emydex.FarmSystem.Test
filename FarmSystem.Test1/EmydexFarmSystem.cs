using FarmSystem.Test2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test
{
    public class EmydexFarmSystem : IEmydexFarmSystem
    {
        private Queue<IAnimal> animalsInFarmSystem = new Queue<IAnimal>();
        //TEST 1
        public void Enter(IAnimal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc)
            Console.WriteLine($"{animal.Species} has entered the Emydex farm");

            //Hold all the animals so it is available for future activities
            animalsInFarmSystem.Enqueue(animal);           
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            if (animalsInFarmSystem.Count > 0)
            {
                foreach (IAnimal animal in animalsInFarmSystem)
                {
                    animal.Talk();
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the farm");
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            List<IMilkableAnimal> milkableAnimals = GetMilkableAnimals();

            if (milkableAnimals.Count > 0)
            {
                foreach (IMilkableAnimal animal in milkableAnimals)
                {
                    animal.ProduceMilk();
                }
            }
            else
            {
                Console.WriteLine("Cannot identify the farm animals which can be milked");
            }        
        }

        private List<IMilkableAnimal> GetMilkableAnimals()
        {
            List<IAnimal> animalList = animalsInFarmSystem.ToList();
            return animalList.OfType<IMilkableAnimal>().ToList();
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
           Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}