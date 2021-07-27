using System;
using StaffClass;
using AnimalClass;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Staff s1 = new Staff();
            Staff s2 = new Staff();

            a1.Name = "Lion";
            a1.Sound = "Roar";

            a2.Name = "Monkey";
            a2.Sound = "oooh";

            s1.Name = "Staff of Healing";
            s1.Id = 1;

            s2.Name = "Staff of Fire";
            s2.Id = 2;

            Console.WriteLine("The " + a1.Name + " makes the sound " + a1.Sound);
            Console.WriteLine("The " + a2.Name + " makes the sound " + a2.Sound);
            Console.WriteLine("The " + s1.Name + " has ID " + s1.Id);
            Console.WriteLine("The " + s2.Name + " has ID " + s2.Id);

        }
    }
}
