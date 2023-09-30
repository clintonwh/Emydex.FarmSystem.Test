using System;

namespace FarmSystem.Test
{
    public class Horse : Animal
    {
        public Horse() : base()
        { 
            NoOfLegs = 4;
            Species = "Horse";
        }

        public override void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }
       
    }
}