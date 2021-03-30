using System;

namespace NestedRepetition {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            int counter = 0;
            int counter2;

            while (counter < 10) {

                counter = counter + 1;
                counter2 = counter;

                while (counter2 < 5) {

                    Console.WriteLine(name);
                    counter2 = counter2 + 1;
                }   
                Console.WriteLine();
            }
            Console.WriteLine("Goodbye " + name);
        }   
    }
}