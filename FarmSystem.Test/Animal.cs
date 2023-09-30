using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test
{
    public class Animal : IAnimal
    {
        private string _id;
        private int _noOfLegs;
        private string _species = "Unknown animal";

        public Animal()
        {
            this._id = Id = Guid.NewGuid().ToString();
        }

        public string Id
        {
            get { return _id; }
            protected set
            {
                _id = value;
            }
        }

        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            protected set
            {
                _noOfLegs = value;
            }
        }

        public string Species
        {
            get
            {
                return _species;
            }
            protected set
            {
                _species = value;
            }
        }

        public virtual void Talk()
        {
            Console.WriteLine($"{Species} makes a noise");
        }

        public void Walk()
        {
            Console.WriteLine($"{Species} is walking");
        }

        public void Run()
        {
            Console.WriteLine($"{Species} is running");
        }

        public void Release()
        {
            Console.WriteLine($"{Species} has left the farm");
        }
    }
}
