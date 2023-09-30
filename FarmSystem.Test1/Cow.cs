using FarmSystem.Test2;
using System;

namespace FarmSystem.Test
{
    public class Cow : MilkableAnimal, IMilkableAnimal
    {
        public Cow() : base()
        { 
            NoOfLegs = 4;
            Species = "Cow";
        }

        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }
    }
}