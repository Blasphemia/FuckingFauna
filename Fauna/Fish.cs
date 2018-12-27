using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    public class Fish : Animal, ICanSwim
    {
        public void Parameters()
        {
            Console.WriteLine($"{Name}, length {Length} cm , {Weight} kg");
        }
        public void CanSwim()
        {
            Console.WriteLine($"{Name}  can swim ");
        }
        public void EatAnimals(Animal animal)
        {
            Console.WriteLine($"{Name} can eat  {animal.Name}");
        }
        public void EatShellfish()
        {
            Console.WriteLine($"{Name} can eat  shellfish");
        }
    }
}
