using System;
using System.Collections.Generic;
using System.Text;

namespace Z2PChallengeInheritanceANDInterface
{
    interface IAnimal
    {
        string Name { get; set; }
        string Color { get; set; }
        int Age { get; set; }

        void Breathe();
    }
}
