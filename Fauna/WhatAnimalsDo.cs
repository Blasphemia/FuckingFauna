using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    public class WhatAnimalsDo
    {
        public void AnimalsActivity()
        {
            Fish flounder = new Fish { Name = "Flounder", Length = 30, Weight = 0.2 };
            flounder.Parameters();
            flounder.CanSwim();
            flounder.EatShellfish();
            Space();

            Cat cat = new Cat { Name = "Cat", Length = 50, Weight = 5 };
            cat.Parameters();
            cat.CanGo();
            cat.EatAnimal(flounder);
            Space();

            Dog dog = new Dog { Name = "Blue Dog", Length = 80, Weight = 30 };
            dog.Parameters();
            dog.CanGo();
            dog.EatAnimal(flounder);
            Space();

            Cow cow = new Cow { Name = "Cow", Length = 150, Weight = 70 };
            cow.Parameters();
            cow.CanGo();
            cow.EatGrass();
            Space();

            Rabbit rabbit = new Rabbit { Name = "Rabbit", Length = 15, Weight = 0.3 };
            rabbit.Parameters();
            rabbit.CanGo();
            rabbit.EatGrass();
            Space();


            Nightingale nightingale = new Nightingale { Name = "Nightingale",  Length = 5, Weight = 0.2 };
            nightingale.Parameters();
            nightingale.CanFly();
            nightingale.EatSeeds();
            Space();

            Dove dove = new Dove { Name = "Dove",  Length = 10, Weight = 0.5 };
            dove.Parameters();
            dove.CanFly();
            dove.EatSeeds();
            Space();

            Eagle eagle = new Eagle { Name = "Eagle", Length = 50, Weight = 5 };
            eagle.Parameters();
            eagle.EatAnimal(cat);
            eagle.CanFly();
            Space();

            Shark shark = new Shark { Name = "Shark", Length = 300, Weight = 100 };
            shark.Parameters();
            shark.CanSwim();
            shark.EatAnimals(flounder);







        }
        public void Space()
        {
            Console.WriteLine("\n");
        }
    }

    
}