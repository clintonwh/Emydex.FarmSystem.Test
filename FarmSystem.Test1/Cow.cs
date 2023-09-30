using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal
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

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

    }
}