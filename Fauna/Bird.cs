using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    public class Bird : Animal, ICanFly
    {
        public void Parameters()
        {
            Console.WriteLine($"{Name}, length {Length} cm , {Weight} kg");
        }

        public void CanFly()
        {
            Console.WriteLine($"{Name} can fly");
        }

        public void EatAnimal(Animal animal)
        {
            Console.WriteLine($"{Name} can eat {animal.Name} ");
        }

        public void EatSeeds()
        {
            Console.WriteLine($"{Name} eat seeds ");
        }
    }
}
