using System;

namespace FarmSystem.Test
{
    public class Hen : Animal
    {
        public Hen(): base()
        {
            NoOfLegs = 2;
            Species = "Hen";
        }

        public override void Talk()
        {
            Console.WriteLine("Hen says CLUCKAAAAAWWWWK!");
        }      
    }
}