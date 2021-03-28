using System;

namespace IfStatements {
    class Program {
        static void Main(string[] args) {

            String age;

            //ask for age 
            Console.WriteLine("Age: "); 
            age = Console.ReadLine();

            //turn string into an integer and check to see if it is a valid input

            if(int.TryParse(age, out int number)) {
                if(number > 17) {
                    Console.WriteLine("Legally adult age.");
                } else {
                    Console.WriteLine("Legally not adult age.");
                }
            } else {
                Console.WriteLine("Invalid Input.");
            }
        }
    }
}