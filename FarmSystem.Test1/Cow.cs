using FarmSystem.Test1;
using FarmSystem.Test3;
using System;

namespace FarmSystem.Test1
{
    public class Cow:IAnimal,IMilkableAnimal
    {
        private string _id;
        private int _noOfLegs = 4;


        public string Id
        {
            get { return _id; }
            set
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
            set
            {
                _noOfLegs = 4;
            }
        }

        public void Enter()
        {
            Console.WriteLine("Cow has entered the farm");
        }

        public void Release()
        {
            Console.WriteLine("Cow has left the farm");
        }

        public void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }

        public void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}