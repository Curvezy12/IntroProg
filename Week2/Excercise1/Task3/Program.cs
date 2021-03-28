using System;

namespace Task3 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("First Number: ");
            string FirstNum = Console.ReadLine();
            Console.WriteLine("Second Number: ");
            string SecondNum = Console.ReadLine();

            int.TryParse(FirstNum, out int FirstNum_Int);
            int.TryParse(SecondNum, out int SecondNum_Int);

            if (FirstNum_Int + SecondNum_Int > 10) {
                Console.WriteLine("Sum of numbers is greater than 10.");
            } else if (FirstNum_Int + SecondNum_Int == 10) {
                Console.WriteLine("Sum of numbers is equal than 10.");
            } else {
                Console.WriteLine("Sum of numbers is less than 10.");
            }

        }
    }
}
