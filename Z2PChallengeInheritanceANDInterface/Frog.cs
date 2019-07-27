using System;
using System.Collections.Generic;
using System.Text;

namespace Z2PChallengeInheritanceANDInterface
{
    class Frog: IAnimal
    {
        public int NumberOfgills { get; set; }
        public string Name { get; set; }
        public string Color { get; set ; }
        public int Age { get; set; }

        public void Breathe()
        {
            Console.WriteLine("I'm Breathing");
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }
    }
}
