using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{

    public class Mammal : Animal
    {
        public void Parameters()
        {
            Console.WriteLine($"{Name}, length {Length} cm , {Weight} kg");
        }
        public void CanGo()
        {

            Console.WriteLine($"{Name} can go");
        }
    }
}