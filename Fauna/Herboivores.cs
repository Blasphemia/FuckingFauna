using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    public class Herboivores : Mammal, IEatGrass
    {
        public void EatGrass()
        {
            Console.WriteLine($"{Name} eats grass");
        }
    }
}
