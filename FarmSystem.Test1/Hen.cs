using System;

namespace FarmSystem.Test1
{
    public class Hen:IAnimal 
    {
        private string _id;
        private int _noOfLegs = 2;


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
                _noOfLegs = 2;
            }
        }

        public void Enter()
        {
            Console.WriteLine("Hen has entered the farm");
        }

        public void Release()
        {
            Console.WriteLine("Hen has left the farm");
        }

        public void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}