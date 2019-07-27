using System;
using System.Collections.Generic;
using System.Text;

namespace Z2PChallengeInheritanceANDInterface
{
    class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public int NumberOflegs { get; set; }

        public void Bark()
        {
         Console.WriteLine("I'm barking");
        }

        public void Breathe()
        {
            Console.WriteLine("I'm breathing"); 
        }
    }
}
