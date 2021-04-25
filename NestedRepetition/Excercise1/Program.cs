using System;

namespace NestedRepetition {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("How many times woudl you like to print it?");
            string amount = Console.ReadLine();

            int counter = 0;

            int.TryParse(amount, out int amount_int);

            while (counter < amount_int) {

                Console.WriteLine(name);
                counter++;
               
            }
        }   
    }
}