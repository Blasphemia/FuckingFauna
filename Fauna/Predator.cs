using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    public class Predator : Mammal, IEatAnimal
    {
        
        public void EatAnimal(Animal animal)
        {
            Console.WriteLine($"{Name} can eat {animal.Name} ");
        }
    }
}
