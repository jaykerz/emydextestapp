using System;
using System.Collections.Generic;
using FarmSystem.Test3;

namespace FarmSystem.Test1
{

    public class EmydexFarmSystem
    {
        private List<IAnimal> animals;

        public delegate void eventRaiser();
        public event eventRaiser FarmEmpty;

        public void farmEmpty()
        {
            Console.WriteLine("Emydex Farm is now empty");
        }

        //TEST 1
        public void Enter(IAnimal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities

            if (animals == null)
            {
                animals = new List<IAnimal>();
            }

            animals.Add(animal);
            animal.Enter();
        }

        //TEST 2
        public void MakeNoise(IAnimal animal)
        {
            //Test 2 : Modify this method to make the animals talk
            animal.Talk();
        }

        //TEST 3
        public void MilkAnimals(List<IAnimal> animals)
        {
            //Console.WriteLine("Cannot identify the farm animals which can be milked");

            foreach (IAnimal animal in animals)
            {
                foreach (Type tinterface in animal.GetType().GetInterfaces())
                {
                    if (tinterface == typeof(IMilkableAnimal))
                    {
                        //Console.WriteLine("Cow was milked");
                        IMilkableAnimal milkable = (IMilkableAnimal)animal;
                        milkable.ProduceMilk();

                    }
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            if (animals != null)
            {
                foreach (IAnimal animal in animals)
                {
                    animal.Release();
                }

                animals.Clear();

                if (animals.Count == 0 && FarmEmpty != null)
                {
                    FarmEmpty();
                }
                else
                {
                    Console.WriteLine("There are still animals in the farm, farm is not free");
                }
            }
            else
            {
                FarmEmpty();
            }
        }
    }
}