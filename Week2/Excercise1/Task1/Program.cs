using System;

namespace IfStatements {
    class Program {
        static void Main(string[] args) {

            String age;

            Console.WriteLine("Age: "); 
            age = Console.ReadLine();

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