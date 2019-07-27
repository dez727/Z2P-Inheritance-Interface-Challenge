using System;

namespace Z2PChallengeInheritanceANDInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Dez";
            myDog.Age = 25;
            myDog.Color = "Black";
            myDog.NumberOflegs = 2;
            myDog.Bark();
            myDog.Breathe();

            Console.WriteLine(myDog.Name);
            Console.WriteLine(myDog.Age);
            Console.WriteLine(myDog.Color);
            Console.WriteLine(myDog.NumberOflegs);



            Frog myFrog = new Frog();
            myFrog.Name = "Lexee";
            myFrog.Age = 22;
            myFrog.Color = "Golden brown";
            myFrog.NumberOfgills = 2;
            myFrog.Swim();
            myFrog.Breathe();

            Console.WriteLine(myFrog.Name);
            Console.WriteLine(myFrog.Age);
            Console.WriteLine(myFrog.Color);
            Console.WriteLine(myFrog.NumberOfgills);

        }
    }

}
