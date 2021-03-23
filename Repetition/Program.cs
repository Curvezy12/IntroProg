using System;

namespace Repetition {

    class Program {

        static void Main(string[] args) {

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("How Many Times Should I Print It? ");
            string number = Console.ReadLine();

            int counter = 0;

            while(counter < int.Parse(number)) {
                Console.WriteLine(name);
                Console.Write("Enter Name: ");

                name = Console.ReadLine();

                counter++;
            }
        }
    }
}