using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test
{
    public  class MilkableAnimal : Animal
    {
        public void ProduceMilk()
        {
            Console.WriteLine($"{Species} was milked!");
        }
    }
}
