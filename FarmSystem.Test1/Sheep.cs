using System;

namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
        public Sheep() : base()
        { 
            NoOfLegs = 4;
            Species = "Sheep";
        }

        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
    }

}