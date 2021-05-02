using System;

namespace Task2 {   
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter Age: ");
            string Age = Console.ReadLine();
            Console.WriteLine("Male or Female: ");
            string Gender = Console.ReadLine();

            int.TryParse(Age, out int Age_Int);
            
            if(Age_Int > 17) {
                Console.WriteLine(Gender + " is an Adult");
            } else {
                Console.WriteLine(Gender + " is not an Adult");
            }
        }
    }
}
