using System;

namespace FarmSystem.Test1
{
    public class Sheep:IAnimal 
    {
       
        private string _id;
        private int _noOfLegs;

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
            Console.WriteLine("Hen has entered the farm");
        }

        public void Release()
        {
            Console.WriteLine("Sheep has left the farm");
        }

        public void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}